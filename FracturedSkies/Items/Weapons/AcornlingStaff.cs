using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Weapons
{
	public class AcornlingStaff : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Acornling Staff";
            item.damage = 5;
            item.summon = true;
            item.mana = 10;
            item.width = 42;
            item.height = 42;
            item.toolTip = "Summons an Acornling to fight for you.";
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 30, 0, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item44;
            item.shoot = mod.ProjectileType("Acornling");
			item.buffType = mod.BuffType("AcornlingBuff");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
		}
		
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}
		
		public override bool UseItem(Player player)
		{
			if(player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddIngredient(ItemID.Acorn, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
