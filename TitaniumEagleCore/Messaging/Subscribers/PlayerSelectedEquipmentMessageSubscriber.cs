using TitaniumEagleCore.Messaging.Messages;
using TitaniumEagleCore.State;

namespace TitaniumEagleCore.Messaging.Subscribers
{
    internal class PlayerSelectedEquipmentMessageSubscriber : ISubscriber<PlayerSelectedEquipmentMessage>
    {
        public GameState Process(GameState state, PlayerSelectedEquipmentMessage message)
        {
            return new GameState
            {
                LevelSelectState = state.LevelSelectState,
                LevelState = new LevelState
                {
                    PlayerOne = new CharacterInstance
                    {
                        Player = state.LevelState.PlayerOne.Player,
                        Character = state.LevelState.PlayerOne.Character,
                        MainHand = message.MainHand,
                        OffHand = message.OffHand,
                        Armor = message.Armor,
                        Accessory = message.Accessory
                    },
                    PlayerTwo = state.LevelState.PlayerTwo,
                    PlayerThree = state.LevelState.PlayerThree,
                    PlayerFour = state.LevelState.PlayerFour
                }
            };
        }
    }
}
