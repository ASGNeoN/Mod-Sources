using Terraria.ID;
using Terraria.ModLoader;

namespace RedDawn.Items.Drops.BossDrops
{
	public class OpticFragment : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Optic Fragment";
			item.width = 40;
			item.height = 40;
			item.toolTip = "Part of a broken sword!";
			item.toolTip2 = "It seems to show another world...";
			item.value = 50000;
			item.rare = 3;
		}
	}
}