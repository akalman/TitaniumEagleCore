using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
     
    public static class InventorySlotRepository
    {
        private static Dictionary<Guid, InventorySlot> InventorySlots = new Dictionary<Guid, InventorySlot>();

        public static InventorySlot Get(Guid id)
        {
            if (InventorySlots.ContainsKey(id))
            {
                return InventorySlots[id];
            }

            return InventorySlot.Empty;
        }

        public static ReadOnlyCollection<InventorySlot> Get()
        {
            return new ReadOnlyCollection<InventorySlot>(InventorySlots.Values.ToList());
        }

        public static InventorySlot Create(Character character, Equipment equipment)
        {
            var slot = new InventorySlot
            {
                Id = Guid.NewGuid(),
                CharacterId = character.Id,
                EquipmentId = equipment.Id
            };

            InventorySlots[slot.Id] = slot;
            return slot;
        }
    }
}
