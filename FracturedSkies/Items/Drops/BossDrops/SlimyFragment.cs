using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Drops.BossDrops
{
	public class SlimyFragment : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Fragment");
            Tooltip.SetDefault("Part of a broken sword!" + "\nIt's covered in slime...");
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