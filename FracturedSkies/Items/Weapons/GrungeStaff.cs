using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Weapons
{
	public class GrungeStaff : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grunge Staff");
            Tooltip.SetDefault("Shoots tiny eaters");
        }
        public override void SetDefaults()
		{
            item.damage = 13;
			item.autoReuse = true;
            item.magic = true;
			item.mana = 7;
            item.width = 38;
            item.height = 38;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
			item.noMelee = true;
            item.noUseGraphic = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 3, 0, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item44;
			projOnSwing = true;
			item.shoot = ProjectileID.EatersBite;
            item.shootSpeed = 7f;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}