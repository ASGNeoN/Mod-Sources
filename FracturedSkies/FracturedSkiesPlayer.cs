using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies
{
    public class FracturedSkiesPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool Acornling = false;
        public static bool hasProjectile;

        public override void ResetEffects()
        {
            Acornling = false;
        }
    }
}