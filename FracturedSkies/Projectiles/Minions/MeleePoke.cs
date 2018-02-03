using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Projectiles.Minions
{
    public abstract class MeleePoke : Minion
	{
		
		public override void Behavior()
		{
			projectile.aiStyle = 266;
		}
	}
}