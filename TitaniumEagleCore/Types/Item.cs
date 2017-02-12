namespace TitaniumEagleCore.Types
{
    public class Item
    {
        public int Attack { get; internal set; }
        public int Magic { get; internal set; }
        public int Defense { get; internal set; }
        public ItemType Type { get; internal set; }
    }
}
