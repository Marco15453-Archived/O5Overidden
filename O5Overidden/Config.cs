using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace O5Overidden
{
    public sealed class Config : IConfig
    {
        [Description("Should the plugin be enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Cooldown for the O5 Overidden (-1 = Disabled)")]
        public int Cooldown { get; set; } = 30;

        [Description("Cooldown Message")]
        public string CooldownMessage { get; set; } = "<color=red>You need to wait %COOLDOWN% seconds before you can overide an door again";

        [Description("The message that will be displayed when a player successfully overidden an door (Empty = Disabled)")]
        public string OverridenMessage { get; set; } = "<color=blue>You overidden the Door, It has been unlocked";

        [Description("What DoorLockTypes should the O5 Override?")]
        public HashSet<DoorLockType> AffectedLockTypes { get; set; } = new HashSet<DoorLockType>
        {
            DoorLockType.Lockdown079,
            DoorLockType.Regular079
        };

        [Description("Blacklisted Doors")]
        public HashSet<DoorType> BlacklistedDoors { get; set; } = new HashSet<DoorType>
        {
            DoorType.Scp106Bottom,
            DoorType.Scp106Primary,
            DoorType.Scp106Secondary
        };
    }
}
