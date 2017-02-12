using TitaniumEagleCore.Data;

namespace TitaniumEagleCore.State
{
    public class CharacterInstance
    {
        public Player Player { get; internal set; }
        public Character Character { get; internal set; }
        public InventorySlot MainHand { get; internal set; }
        public InventorySlot OffHand { get; internal set; }
        public InventorySlot Armor { get; internal set; }
        public InventorySlot Accessory { get; internal set; }

        public static CharacterInstance Empty = new CharacterInstance
        {
            Player = Player.Empty,
            Character = Character.Empty,
            MainHand = InventorySlot.Empty,
            OffHand = InventorySlot.Empty,
            Armor = InventorySlot.Empty,
            Accessory = InventorySlot.Empty
        };
    }
}
