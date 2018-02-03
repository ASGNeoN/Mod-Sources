using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Weapons
{
	public class PhotonBlaster : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Photon Blaster");
            Tooltip.SetDefault("Shoots charged bullet");
        }
        public override void SetDefaults()
		{
            item.damage = 40;
			item.autoReuse = true;
            item.ranged = true;
            item.width = 40;
            item.height = 29;
			item.noMelee = true;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 3, 0, 0);
            item.rare = 8;
			item.UseSound = SoundID.Item42;
			projOnSwing = true;
            item.shootSpeed = 9f;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = 20;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ProjectileID.PulseBolt;
			return true;
		}
	}
}