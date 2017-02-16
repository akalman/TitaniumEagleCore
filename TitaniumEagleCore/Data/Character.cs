using System;

namespace TitaniumEagleCore.Data
{
    public class Character
    {
        internal Character() { }

        public static Character Empty = new Character
        {
            Id = Guid.Empty
        };

        public Guid Id { get; internal set; }
        public Guid PlayerId { get; internal set; }
    }
}
