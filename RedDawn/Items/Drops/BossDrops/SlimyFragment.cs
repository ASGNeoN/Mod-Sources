using Terraria.ID;
using Terraria.ModLoader;

namespace RedDawn.Items.Drops.BossDrops
{
	public class SlimyFragment : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Slimy Fragment";
			item.width = 40;
			item.height = 40;
			item.toolTip = "Part of a broken sword!";
			item.toolTip2 = "It's covered in slime...";
			item.value = 50000;
			item.rare = 3;
		}
	}
}