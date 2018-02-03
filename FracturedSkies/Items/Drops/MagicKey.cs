using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Drops
{

    public class MagicKey : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Key");
            Tooltip.SetDefault("A... Key? If it's a key," + "\nthere's gotta be treasure.");
		}
        public override void SetDefaults()
		{
			item.width = 38;
			item.height = 22;
			item.consumable = true;
			item.maxStack = 99;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 5;
			item.value = 50000;
			item.rare = 3;
			item.UseSound = SoundID.Item29;
		}
		public bool skull = true;
		public override bool UseItem(Player player)
		{
			int i = (int) player.position.X / 16;
			int j = (int) player.position.Y / 16;
			if (skull == true)
			{
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
				skull = false;
			}
			bool killtile = false;
			if (Main.tile[i,j].type == TileID.BlueDungeonBrick || Main.tile[i, j].type == TileID.GreenDungeonBrick || Main.tile[i, j].type == TileID.PinkDungeonBrick)
			{
				killtile = true;
			}
			else
			{
				killtile = false;
			}
			for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
			{
				WorldGen.TileRunner(
				WorldGen.genRand.Next(0, Main.maxTilesX),
				WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY),
				(double)WorldGen.genRand.Next(6,12),
				WorldGen.genRand.Next(4,6),
				mod.TileType("FortuneOreTile"),
				false, 0f, 0f, false, killtile);
			};
			return true;
		}
	}
}