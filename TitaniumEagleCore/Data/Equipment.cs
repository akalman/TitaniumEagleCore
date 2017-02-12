using System;
using System.Collections.Generic;
using TitaniumEagleCore.Types;

namespace TitaniumEagleCore.Data
{
    public class Equipment
    {
        internal Equipment() { }

        public static Equipment Empty = new Equipment
        {
            Id = Guid.Empty
        };

        public Guid Id { get; internal set; }
        public Item Item { get; internal set; }
        public string ItemSlot { get; internal set; }
    }

    public static class EquipmentRepository
    {
        private static Dictionary<Guid, Equipment> Equipments = new Dictionary<Guid, Equipment>();

        public static Equipment Get(Guid id)
        {
            if (Equipments.ContainsKey(id))
            {
                return Equipments[id];
            }

            return Equipment.Empty;
        }

        public static Equipment Create(Item item)
        {
            var equipment = new Equipment
            {
                Id = Guid.NewGuid(),
                Item = item
            };

            Equipments[equipment.Id] = equipment;
            return equipment;
        }
    }
}
