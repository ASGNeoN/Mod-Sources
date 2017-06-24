using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedDawn.Items.Loot
{
	public class FortuneBar : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Fortune Bar";
			item.width = 14;
			item.height = 14;
			item.toolTip = "Some treasure stolen from the Dungeon";
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 300;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.consumable = true;
			item.createTile = mod.TileType("FortuneBarTile");
			item.maxStack = 99;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FortuneOre", 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}	
}