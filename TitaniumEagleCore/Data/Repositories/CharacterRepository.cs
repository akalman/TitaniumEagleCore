using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TitaniumEagleCore.Data.Repositories
{
    public class CharacterRepository
    {
        private Dictionary<Guid, Character> _characters = new Dictionary<Guid, Character>();

        public Character Get(Guid id)
        {
            if (_characters.ContainsKey(id))
            {
                return _characters[id];
            }

            return Character.Empty;
        }

        public ReadOnlyCollection<Character> Get()
        {
            return new ReadOnlyCollection<Character>(_characters.Values.ToList());
        }

        public Character Create(Player player)
        {
            var character = new Character
            {
                Id = Guid.NewGuid(),
                PlayerId = player.Id
            };

            _characters[character.Id] = character;
            return character;
        }
    }
}
