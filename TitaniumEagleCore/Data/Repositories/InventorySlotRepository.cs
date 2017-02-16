using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TitaniumEagleCore.Data.Repositories
{
    public class InventorySlotRepository
    {
        private Dictionary<Guid, InventorySlot> _inventorySlots = new Dictionary<Guid, InventorySlot>();

        public InventorySlot Get(Guid id)
        {
            if (_inventorySlots.ContainsKey(id))
            {
                return _inventorySlots[id];
            }

            return InventorySlot.Empty;
        }

        public ReadOnlyCollection<InventorySlot> Get()
        {
            return new ReadOnlyCollection<InventorySlot>(_inventorySlots.Values.ToList());
        }

        public InventorySlot Create(Character character, Equipment equipment)
        {
            var slot = new InventorySlot
            {
                Id = Guid.NewGuid(),
                CharacterId = character.Id,
                EquipmentId = equipment.Id
            };

            _inventorySlots[slot.Id] = slot;
            return slot;
        }
    }
}
