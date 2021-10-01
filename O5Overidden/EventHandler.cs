using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;

namespace O5Overidden
{
    internal sealed class EventHandler
    {
        public Plugin plugin;
        public EventHandler(Plugin plugin) => this.plugin = plugin;

        private Dictionary<Player, DateTime> activeCooldowns = new Dictionary<Player, DateTime>();

        public void onInteractingDoor(InteractingDoorEventArgs ev)
        {
            if (!ev.IsAllowed || ev.Door.IsOpen || ev.Player.CurrentItem == null || ev.Player.CurrentItem.Type != ItemType.KeycardO5 || !plugin.Config.AffectedLockTypes.Contains(ev.Door.DoorLockType) || plugin.Config.BlacklistedDoors.Contains(ev.Door.Type)) return;
            
            if(plugin.Config.Cooldown > 0 && plugin.Config.CooldownMessage != null && activeCooldowns.ContainsKey(ev.Player) && DateTime.Now < (activeCooldowns[ev.Player] + TimeSpan.FromSeconds(plugin.Config.Cooldown)))
            {
                ev.Player.ShowHint(plugin.Config.CooldownMessage.Replace("%COOLDOWN%", Math.Round(((activeCooldowns[ev.Player] + TimeSpan.FromSeconds(plugin.Config.Cooldown)) - DateTime.Now).TotalSeconds).ToString()));
                return;
            }

            ev.Door.IsOpen = true;
            ev.Door.Unlock();

            if (plugin.Config.Cooldown > 0)
                activeCooldowns[ev.Player] = DateTime.Now;
            if (plugin.Config.OverridenMessage != null)
                ev.Player.ShowHint(plugin.Config.OverridenMessage);
        }
    }
}
