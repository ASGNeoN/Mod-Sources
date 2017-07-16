using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Microsoft.Xna.Framework.Graphics;

namespace FracturedSkies.Items.Drops
{
	public class MagicKey : ModItem
	{
		/*public bool l : if (type = TileID.BlueDungeonBrick || type = TileID.GreenDungeonBrick || type = TileID.PinkDungeonBrick)
			{
				true
			}
			else ()
			{
				false
			}*/
		public override void SetDefaults()
		{
			item.name = "Magic Key";
			item.width = 38;
			item.height = 22;
			item.consumable = true;
			item.maxStack = 99;
			item.toolTip = "A... Key? If it's a key,";
			item.toolTip2 = "there's gotta be treasure.";
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 4;
			item.value = 50000;
			item.rare = 4;
			item.UseSound = SoundID.Item6;
		}
		public override bool UseItem(Player player)
		{
			int i = (int) player.position.X / 16;
			int j = (int) player.position.Y / 16;
			for (i = (int) player.position.X / 16 - 4; i < (int) player.position.X / 16 + 12; i += 15)
            {
				WorldGen.PlaceTile(i, j - 19, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 18, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 17, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 16, mod.TileType("FortuneOreTile"));
			}			
			for (i = (int) player.position.X / 16 - 3; i < (int) player.position.X / 16 + 11; i += 13)
            {
				WorldGen.PlaceTile(i, j - 21, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 20, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 15, mod.TileType("FortuneOreTile"));
			}			
			for (i = (int) player.position.X / 16 - 2; i < (int) player.position.X / 16 + 10; i += 11)
            {
				WorldGen.PlaceTile(i, j - 23, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 22, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 18, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 17, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 16, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 14, mod.TileType("FortuneOreTile"));
			}
			for (i = (int) player.position.X / 16 - 1; i < (int) player.position.X / 16 + 9; i += 9)
            {
				WorldGen.PlaceTile(i, j - 24, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 19, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 18, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 17, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 16, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 15, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 13, mod.TileType("FortuneOreTile"));
                WorldGen.PlaceTile(i, j - 12, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 11, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 9, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 8, mod.TileType("FortuneOreTile"));
            }
			for (i = (int) player.position.X / 16; i < (int) player.position.X / 16 + 8; i += 7)
            {
				WorldGen.PlaceTile(i, j - 24, mod.TileType("FortuneOreTile"));				
				WorldGen.PlaceTile(i, j - 19, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 18, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 17, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 16, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 15, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 10, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 7, mod.TileType("FortuneOreTile"));
				}
			for (i = (int) player.position.X / 16 + 1; i < (int) player.position.X / 16 + 7; i += 5)
            {
                WorldGen.PlaceTile(i, j - 25, mod.TileType("FortuneOreTile"));				
				WorldGen.PlaceTile(i, j - 19, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 18, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 17, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 16, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 15, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 10, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 9, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 7, mod.TileType("FortuneOreTile"));
            }
			for (i = (int) player.position.X / 16 + 2; i < (int) player.position.X / 16 + 6; i += 3)
            {
				WorldGen.PlaceTile(i, j - 25, mod.TileType("FortuneOreTile"));				
				WorldGen.PlaceTile(i, j - 19, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 18, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 17, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 16, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 11, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 10, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 6, mod.TileType("FortuneOreTile"));
			}
			for (i = (int) player.position.X / 16 + 3; i < (int) player.position.X / 16 + 5; i += 1)
            {
				WorldGen.PlaceTile(i, j - 25, mod.TileType("FortuneOreTile"));				
				WorldGen.PlaceTile(i, j - 14, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 13, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 10, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 9, mod.TileType("FortuneOreTile"));
				WorldGen.PlaceTile(i, j - 6, mod.TileType("FortuneOreTile"));
			}
			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
				WorldGen.TileRunner(
				WorldGen.genRand.Next(0, Main.maxTilesX),
				WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY),
				(double)WorldGen.genRand.Next(6,12),
				WorldGen.genRand.Next(4,6),
				mod.TileType("FortuneOreTile"),
				false, 0f, 0f, false, true);
            };
			return true;
		}
	}
}