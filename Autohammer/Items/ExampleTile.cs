using Terraria.ID;
using Terraria.ModLoader;

namespace Autohammer.Items
{
	public class ExampleTile : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Example Tile";
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			AddTooltip("Used to modify and create Exo Equipment.");
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("ExampleTile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}