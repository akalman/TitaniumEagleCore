using System;
using System.Collections.Generic;
using TitaniumEagleCore.Types;

namespace TitaniumEagleCore.Data.Repositories
{
    public class EquipmentRepository
    {
        private Dictionary<Guid, Equipment> _equipments = new Dictionary<Guid, Equipment>();

        public Equipment Get(Guid id)
        {
            if (_equipments.ContainsKey(id))
            {
                return _equipments[id];
            }

            return Equipment.Empty;
        }

        public Equipment Create(Item item)
        {
            var equipment = new Equipment
            {
                Id = Guid.NewGuid(),
                Item = item
            };

            _equipments[equipment.Id] = equipment;
            return equipment;
        }
    }
}
