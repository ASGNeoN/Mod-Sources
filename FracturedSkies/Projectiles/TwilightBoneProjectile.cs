using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FracturedSkies.Projectiles
{
    public class TwilightBoneProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twilight Bone");
        }
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 1000;
            projectile.extraUpdates = 1;
            projectile.damage = 250;
            projectile.ignoreWater = false;
            projectile.aiStyle = 1;
        }

        public override void AI()
        {
            projectile.rotation += projectile.velocity.X * 10f;
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(BuffID.CursedInferno, 300);
            }
        }
    }
}
