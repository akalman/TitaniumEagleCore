using TitaniumEagleCore.Data.Repositories;

namespace TitaniumEagleCore.Context
{
    public static class Repositories
    {
        public static CharacterRepository Characters = new CharacterRepository();
        public static EquipmentRepository Equipments = new EquipmentRepository();
        public static InventorySlotRepository InventorySlots = new InventorySlotRepository();
        public static PlayerRepository Players = new PlayerRepository();
    }
}
