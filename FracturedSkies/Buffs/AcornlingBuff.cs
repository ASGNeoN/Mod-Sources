using Terraria;
using Terraria.ModLoader;

namespace FracturedSkies.Buffs
{
	public class AcornlingBuff : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffName[Type] = "Acornling";
			Main.buffTip[Type] = "A little Acornling will fight for you";
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			FracturedSkiesPlayer modPlayer = player.GetModPlayer<FracturedSkiesPlayer>(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("Acornling")] > 0)
			{
				modPlayer.Acornling = true;
			}
			if (!modPlayer.Acornling)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}