using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Drops.BossDrops
{
	public class OpticFragment : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Optic Fragment");
            Tooltip.SetDefault("Part of a broken sword!" + "\nIt seems to show another world...");
        }
        public override void SetDefaults()
		{
			item.width = 40;
			item.height = 40;
			item.value = 50000;
			item.rare = 3;
		}
	}
}