using System;

namespace TitaniumEagleCore.Data
{
    public class Player
    {
        internal Player() { }

        public static Player Empty = new Player
        {
            Id = Guid.Empty
        };

        public Guid Id { get; internal set; }
    }
}
