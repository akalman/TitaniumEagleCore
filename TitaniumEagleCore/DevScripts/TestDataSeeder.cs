using TitaniumEagleCore.Context;
using TitaniumEagleCore.Data;
using TitaniumEagleCore.Types.Instances;

namespace TitaniumEagleCore.DevScripts
{
    public class TestDataSeeder
    {
        public void Seed()
        {
            var player1 = Repositories.Players.Create();

            var character1 = Repositories.Characters.Create(player1);
            var sword1 = Repositories.Equipments.Create(Weapons.BasicSword);
            var character1sword = Repositories.InventorySlots.Create(character1, sword1);
            var armor1 = Repositories.Equipments.Create(Armors.BasicArmor);
            var character1armor = Repositories.InventorySlots.Create(character1, armor1);
        }
    }
}
