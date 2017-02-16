using System;
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
}
