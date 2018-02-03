using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FracturedSkies.Items.Drops
{
	public class TwilightBone : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twilight Bone");
            Tooltip.SetDefault("Twilight oozes from this bone");
        }
        public override void SetDefaults()
        {
            item.damage = 250;
            item.width = 38;
            item.thrown = true;
            item.noMelee = true;
            item.height = 22;
            item.consumable = true;
            item.maxStack = 99;
            item.useTime = 10;
            item.noUseGraphic = true;
            item.useAnimation = 10;
            item.useStyle = 2;
            item.value = 5000;
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("TwilightBoneProjectile");
            item.shootSpeed = 7;
        }
    }
}