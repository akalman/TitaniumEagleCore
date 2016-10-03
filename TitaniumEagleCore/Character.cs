using System;
using System.Collections.Generic;

namespace TitaniumEagleCore
{
    public class Character
    {
        internal Character()
        {
            Equipment = new List<Equipment>();
            ActionBar = new List<Action>();
        }

        public static Character Empty = new Character
        {
            Id = Guid.Empty,
            Equipment = new List<Equipment>().AsReadOnly(),
            ActionBar = new List<Action>().AsReadOnly()
        };

        public Guid Id { get; internal set; }
        public IList<Equipment> Equipment { get; internal set; }
        public IList<Action> ActionBar { get; internal set; }
        public int CurrentHealth { get; internal set; }

        public int Attack { get { return 50; } }
        public int Defense { get { return 30; } }
        public int MaxHealth { get { return 700; } }
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

        public static Character Create()
        {
            var character = new Character
            {
                Id = Guid.NewGuid()
            };

            Characters[character.Id] = character;
            return character;
        }
    }
}
