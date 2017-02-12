using TitaniumEagleCore.Data;
using TitaniumEagleCore.Types.Instances;

namespace TitaniumEagleCore.DevScripts
{
    public class TestDataSeeder
    {
        public void Seed()
        {
            var player1 = PlayerRepository.Create();

            var character1 = CharacterRepository.Create(player1);
            var sword1 = EquipmentRepository.Create(Weapons.BasicSword);
            var character1sword = InventorySlotRepository.Create(character1, sword1);
            var armor1 = EquipmentRepository.Create(Armors.BasicArmor);
            var character1armor = InventorySlotRepository.Create(character1, armor1);
        }
    }
}
