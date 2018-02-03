using Terraria;
using Terraria.ModLoader;

namespace FracturedSkies.Tiles
{
    public class AstralStoneTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileStone[Type] = false;
			Main.tileLighted[Type] = true;
			Main.tileDungeon[Type] = false;
			Main.tileNoSunLight[Type] = false;
			Main.tileTable[Type] = false;
			Main.tileNoAttach[Type] = false;
			Main.tileFrameImportant[Type] = false;
			Main.tileNoFail[Type] = false;
			drop = mod.ItemType("AstralTile");
			minPick = 210;
		}
	}
}