﻿using TitaniumEagleCore.Data;
using TitaniumEagleCore.Messaging.Messages;
using TitaniumEagleCore.State;

namespace TitaniumEagleCore.Messaging.Subscribers
{
    internal class PlayerSelectedCharacterMessageSubscriber : ISubscriber<PlayerSelectedCharacterMessage>
    {
        public GameState Process(GameState state, PlayerSelectedCharacterMessage message)
        {
            return new GameState
            {
                LevelSelectState = state.LevelSelectState,
                LevelState = new LevelState
                {
                    PlayerOne = new CharacterInstance
                    {
                        Player = PlayerRepository.Get(message.PlayerId),
                        Character = CharacterRepository.Get(message.CharacterId),
                        MainHand = InventorySlot.Empty,
                        OffHand = InventorySlot.Empty,
                        Armor = InventorySlot.Empty,
                        Accessory = InventorySlot.Empty
                    },
                    PlayerTwo = state.LevelState.PlayerTwo,
                    PlayerThree = state.LevelState.PlayerThree,
                    PlayerFour = state.LevelState.PlayerFour
                }
            };
        }
    }
}
