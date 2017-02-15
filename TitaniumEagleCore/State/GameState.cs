namespace TitaniumEagleCore.State
{
    public class GameState
    {
        public LevelState LevelState { get; internal set; }
        public LevelSelectState LevelSelectState { get; internal set; }

        public static GameState Empty = new GameState
        {
            LevelState = LevelState.Empty,
            LevelSelectState = LevelSelectState.Empty
        };
    }
}
