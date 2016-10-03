using System;
using System.Collections.Generic;

namespace TitaniumEagleCore
{
    public class Player
    {
        internal Player() { }

        public static Player Empty = new Player
        {
            Id = Guid.Empty,
            Character = Character.Empty
        };

        public Guid Id { get; internal set; }
        public Character Character { get; internal set; }
    }
     
    public static class PlayerRepository
    {
        private static Dictionary<Guid, Player> Players = new Dictionary<Guid, Player>();

        public static Player Get(Guid id)
        {
            if (Players.ContainsKey(id))
            {
                return Players[id];
            }

            return Player.Empty;
        }

        public static Player Create()
        {
            var player = new Player
            {
                Id = Guid.NewGuid()
            };

            Players[player.Id] = player;
            return player;
        }
    }
}
