using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Drops.BossDrops
{
	public class ForbiddenFragment : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forbidden Fragment");
            Tooltip.SetDefault("Part of a broken sword!" + "\nA dark energy lurks inside...");
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