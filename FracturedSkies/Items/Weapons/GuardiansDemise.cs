using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Weapons
{
	public class GuardiansDemise : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Guardian's Demise");
            Tooltip.SetDefault("This could be useful for something...");
        }
        public override void SetDefaults()
		{
			item.damage = 54;
			item.melee = true;
			item.width = 36;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 500000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("GuardiansDemiseProjectile");
			item.shootSpeed = 10;
		}
		public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if(target.type == 68)
            {
				damage = 11000;
            }
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddIngredient(ItemID.PurpleClubberfish, 1);
			recipe.AddIngredient(ItemID.EnchantedSword, 1);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddIngredient(mod, "SlimyFragment", 1);
			recipe.AddIngredient(mod, "OpticFragment", 1);
			recipe.AddIngredient(mod, "ForbiddenFragment", 1);
			recipe.AddIngredient(mod, "HoneyedFragment", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
