using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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

    public static class CharacterRepository
    {
        private static Dictionary<Guid, Character> Characters = new Dictionary<Guid, Character>();

        public static Character Get(Guid id)
        {
            if (Characters.ContainsKey(id))
            {
                return Characters[id];
            }

            return Character.Empty;
        }

        public static ReadOnlyCollection<Character> Get()
        {
            return new ReadOnlyCollection<Character>(Characters.Values.ToList());
        }

        public static Character Create(Player player)
        {
            var character = new Character
            {
                Id = Guid.NewGuid(),
                PlayerId = player.Id
            };

            Characters[character.Id] = character;
            return character;
        }
    }
}
