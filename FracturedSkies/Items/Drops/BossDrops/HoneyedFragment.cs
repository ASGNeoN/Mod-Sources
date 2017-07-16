using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Drops.BossDrops
{
	public class HoneyedFragment : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Honeyed Fragment";
			item.width = 40;
			item.height = 40;
			item.toolTip = "Part of a broken sword!";
			item.toolTip2 = "It's dripping with honey...";
			item.value = 50000;
			item.rare = 3;
		}
	}
}