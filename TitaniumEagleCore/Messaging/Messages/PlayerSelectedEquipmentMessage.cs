using TitaniumEagleCore.Data;

namespace TitaniumEagleCore.Messaging.Messages
{
    public class PlayerSelectedEquipmentMessage : IMessage
    {
        public InventorySlot MainHand { get; set; }
        public InventorySlot OffHand { get; set; }
        public InventorySlot Armor { get; set; }
        public InventorySlot Accessory { get; set; }
    }
}
