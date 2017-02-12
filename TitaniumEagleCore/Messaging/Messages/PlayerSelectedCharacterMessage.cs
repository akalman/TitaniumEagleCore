using System;

namespace TitaniumEagleCore.Messaging.Messages
{
    public class PlayerSelectedCharacterMessage : IMessage
    {
        public Guid PlayerId { get; set; }
        public Guid CharacterId { get; set; }
    }
}
