using System;

namespace TitaniumEagleCore.Data
{
    public class InventorySlot
    {
        internal InventorySlot() { }

        public static InventorySlot Empty = new InventorySlot
        {
            Id = Guid.Empty
        };

        public Guid Id { get; internal set; }
        public Guid CharacterId { get; internal set; }
        public Guid EquipmentId { get; internal set; }
    }
}
