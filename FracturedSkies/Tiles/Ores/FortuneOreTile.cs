using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Tiles.Ores
{
	public class FortuneOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileStone[Type] = false;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileShine[Type] = 120;
			Main.tileDungeon[Type] = false;
			Main.tileNoSunLight[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileNoAttach[Type] = false;
			Main.tileShine2[Type] = true;
			Main.tileFrameImportant[Type] = false;
			Main.tileNoFail[Type] = false;
			drop = mod.ItemType("FortuneOre");
			AddMapEntry(new Color(0, 233, 132), "Fortune Ore");
			minPick = 70;
		}
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.0f;
			g = 0.91f;
			b = 0.52f;
		}
	}
}