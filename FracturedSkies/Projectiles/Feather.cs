using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Projectiles
{

    public class Feather : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "Feather";
            projectile.width = 15;
            projectile.height = 15;
            projectile.friendly = true;
            projectile.magic = true; 
            projectile.tileCollide = true;
            projectile.penetrate = 1;
			projectile.timeLeft = 200;
            projectile.light = .5f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;

        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, projectile.velocity.X);
        }
    }
}