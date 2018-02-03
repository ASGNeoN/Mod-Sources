using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Weapons
{
   
    public class FeatherFall : ModItem

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Feather Fall");
            Tooltip.SetDefault("Spews feathers");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.magic = true;                     
            item.width = 24;
            item.height = 28;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;       
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 6;
            item.mana = 10;             
            item.UseSound = SoundID.Item15;           
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Feather");
            item.shootSpeed = 5f;
           
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(3);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

    }






}
