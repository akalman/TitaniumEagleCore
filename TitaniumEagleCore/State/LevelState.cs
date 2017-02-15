namespace TitaniumEagleCore.State
{
    public class LevelState
    {
        public CharacterInstance PlayerOne { get; internal set; }
        public CharacterInstance PlayerTwo { get; internal set; }
        public CharacterInstance PlayerThree { get; internal set; }
        public CharacterInstance PlayerFour { get; internal set; }

        public static LevelState Empty = new LevelState
        {
            PlayerOne = CharacterInstance.Empty,
            PlayerTwo = CharacterInstance.Empty,
            PlayerThree = CharacterInstance.Empty,
            PlayerFour = CharacterInstance.Empty
        };
    }
}
