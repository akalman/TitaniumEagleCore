using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TitaniumEagleCore.Data.Repositories
{
    public class PlayerRepository
    {
        private Dictionary<Guid, Player> _players = new Dictionary<Guid, Player>();

        public Player Get(Guid id)
        {
            if (_players.ContainsKey(id))
            {
                return _players[id];
            }

            return Player.Empty;
        }

        public ReadOnlyCollection<Player> Get()
        {
            return new ReadOnlyCollection<Player>(_players.Values.ToList());
        }

        public Player Create()
        {
            var player = new Player
            {
                Id = Guid.NewGuid()
            };

            _players[player.Id] = player;
            return player;
        }
    }
}
