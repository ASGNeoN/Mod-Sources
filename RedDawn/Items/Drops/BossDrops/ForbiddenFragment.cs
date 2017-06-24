using Terraria.ID;
using Terraria.ModLoader;

namespace RedDawn.Items.Drops.BossDrops
{
	public class ForbiddenFragment : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Forbidden Fragment";
			item.width = 40;
			item.height = 40;
			item.toolTip = "Part of a broken sword!";
			item.toolTip2 = "A dark energy lurks inside...";
			item.value = 50000;
			item.rare = 3;
		}
	}
}