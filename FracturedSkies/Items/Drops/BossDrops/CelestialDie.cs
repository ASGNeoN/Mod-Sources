using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Drops.BossDrops
{

    public class CelestialDie : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial Die");
            Tooltip.SetDefault("Choose which weapon you want.");
		}
        public override void SetDefaults()
		{
			item.width = 60;
			item.height = 64;
			item.maxStack = 99;
			item.value = 50000;
			item.rare = 9;
		}
	
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.Meowmere);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.Terrarian);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.StarWrath);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.SDMG);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.FireworksLauncher);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.LastPrism);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.LunarFlareBook);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.RainbowCrystalStaff);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CelestialDie", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.MoonlordTurretStaff);
			recipe.AddRecipe();
		}
	}
}