using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace FracturedSkies.Tiles.Ores
{
	public class FortuneBarTile : ModTile
	{
		
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = false;
			disableSmartCursor = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileShine[Type] = 1100;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			drop = mod.ItemType("FortuneBar");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Fortune Bar");
            AddMapEntry(new Color(0, 233, 132), name);
			minPick = 70;
			TileObjectData.addTile(Type);
		}
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.0f;
			g = 0.91f;
			b = 0.52f;
		}
	}
}