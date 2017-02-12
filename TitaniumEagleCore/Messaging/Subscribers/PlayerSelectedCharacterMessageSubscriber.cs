using System;
using TitaniumEagleCore.Data;
using TitaniumEagleCore.Messaging.Messages;
using TitaniumEagleCore.State;

namespace TitaniumEagleCore.Messaging.Subscribers
{
    internal class PlayerSelectedCharacterMessageSubscriber : ISubscrber<PlayerSelectedCharacterMessage>
    {
        public void Process(PlayerSelectedCharacterMessage message)
        {
            LevelState.PlayerOne = new CharacterInstance
            {
                Player = PlayerRepository.Get(message.PlayerId),
                Character = CharacterRepository.Get(message.CharacterId)
            };
        }
    }
}
