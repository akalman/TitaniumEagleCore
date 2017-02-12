using TitaniumEagleCore.Messaging.Messages;
using TitaniumEagleCore.State;

namespace TitaniumEagleCore.Messaging.Subscribers
{
    internal class PlayerSelectedEquipmentMessageSubscriber : ISubscrber<PlayerSelectedEquipmentMessage>
    {
        public void Process(PlayerSelectedEquipmentMessage message)
        {
            LevelState.PlayerOne.MainHand = message.MainHand;
            LevelState.PlayerOne.OffHand = message.OffHand;
            LevelState.PlayerOne.Armor = message.Armor;
            LevelState.PlayerOne.Accessory = message.Accessory;
        }
    }
}
