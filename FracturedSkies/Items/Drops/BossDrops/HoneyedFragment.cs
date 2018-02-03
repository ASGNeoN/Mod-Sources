using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Drops.BossDrops
{
	public class HoneyedFragment : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Honeyed Fragment");
            Tooltip.SetDefault("Part of a broken sword!" + "\nIt's dripping with honey...");
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