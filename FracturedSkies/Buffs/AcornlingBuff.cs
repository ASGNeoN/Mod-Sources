using Terraria;
using Terraria.ModLoader;

namespace FracturedSkies.Buffs
{
	public class AcornlingBuff : ModBuff
	{
		public override void SetDefaults()
		{
            DisplayName.SetDefault("Acornling");
            Description.SetDefault("A little Acornling will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
		}

		/*public override void Update(Player player, ref int buffIndex)
		{
			FracturedSkiesPlayer modPlayer = player.GetModPlayer FracturedSkiesPlayer(mod);
			if (player.ownedProjectileCounts[mod.ProjectileType("Acornling")] > 0)
			{
				modPlayer.Acornling = true;
				player.buffTime[buffIndex] = 3600;
			}
			if (!modPlayer.Acornling)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 3600;
			}
		}*/
	}
}