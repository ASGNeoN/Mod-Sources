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