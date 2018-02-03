using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Projectiles.Minions
{   
    public class Acornling : MeleePoke
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acornling");
        }
        public override void SetDefaults()
        {
            projectile.netImportant = true;
            projectile.width = 32;
            projectile.height = 32;
            projectile.friendly = true;
			projectile.damage = 5;
			projectile.minion = true;
			//projectile.knockback = 4;
            Main.projPet[projectile.type] = true;
            projectile.minionSlots = 1;
            projectile.penetrate = -1;
            projectile.timeLeft = 18000;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            /*shoot = mod.ProjectileType("AcornlingProjectile");
            shootSpeed = 10f;
            Main.projPet[projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.Homing[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
			inertia = 20f;*/
        }

        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            FracturedSkiesPlayer modPlayer = (FracturedSkiesPlayer)player.GetModPlayer(mod, "FracturedSkiesPlayer");
            if (player.dead)
            {
                modPlayer.Acornling = false;
            }
            if (modPlayer.Acornling)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}