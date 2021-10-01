using Exiled.API.Features;
using System;

using Player = Exiled.Events.Handlers.Player;

namespace O5Overidden
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "O5 Overidden";
        public override string Author => "Marco15453";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        private EventHandler eventHandler;

        public override void OnEnabled()
        {
            eventHandler = new EventHandler(this);
            Player.InteractingDoor += eventHandler.onInteractingDoor;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.InteractingDoor -= eventHandler.onInteractingDoor;
            eventHandler = null;
            base.OnDisabled();
        }
    }
}
