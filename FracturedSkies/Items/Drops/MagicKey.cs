using Terraria;
using Terraria.ID;
using Terraria.GameContent.Generation;
using Terraria.World.Generation;
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

        public override bool UseItem(Player player)
		{
            if (FracturedSkiesWorld.usedKey == false)
            {
                int posX = (int)player.position.X / 16;
                int posY = (int)player.position.Y / 16;
                for (posX = (int)player.position.X / 16 - 4; posX < (int)player.position.X / 16 + 12; posX += 15)
                {
                    WorldGen.PlaceTile(posX, posY - 19, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 18, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 17, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 16, mod.TileType("FortuneOreTile"));
                }
                for (posX = (int)player.position.X / 16 - 3; posX < (int)player.position.X / 16 + 11; posX += 13)
                {
                    WorldGen.PlaceTile(posX, posY - 21, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 20, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 15, mod.TileType("FortuneOreTile"));
                }
                for (posX = (int)player.position.X / 16 - 2; posX < (int)player.position.X / 16 + 10; posX += 11)
                {
                    WorldGen.PlaceTile(posX, posY - 23, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 22, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 18, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 17, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 16, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 14, mod.TileType("FortuneOreTile"));
                }
                for (posX = (int)player.position.X / 16 - 1; posX < (int)player.position.X / 16 + 9; posX += 9)
                {
                    WorldGen.PlaceTile(posX, posY - 24, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 19, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 18, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 17, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 16, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 15, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 13, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 12, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 11, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 9, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 8, mod.TileType("FortuneOreTile"));
                }
                for (posX = (int)player.position.X / 16; posX < (int)player.position.X / 16 + 8; posX += 7)
                {
                    WorldGen.PlaceTile(posX, posY - 24, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 19, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 18, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 17, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 16, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 15, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 10, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 7, mod.TileType("FortuneOreTile"));
                }
                for (posX = (int)player.position.X / 16 + 1; posX < (int)player.position.X / 16 + 7; posX += 5)
                {
                    WorldGen.PlaceTile(posX, posY - 25, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 19, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 18, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 17, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 16, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 15, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 10, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 9, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 7, mod.TileType("FortuneOreTile"));
                }
                for (posX = (int)player.position.X / 16 + 2; posX < (int)player.position.X / 16 + 6; posX += 3)
                {
                    WorldGen.PlaceTile(posX, posY - 25, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 19, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 18, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 17, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 16, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 11, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 10, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 6, mod.TileType("FortuneOreTile"));
                }
                for (posX = (int)player.position.X / 16 + 3; posX < (int)player.position.X / 16 + 5; posX += 1)
                {
                    WorldGen.PlaceTile(posX, posY - 25, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 14, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 13, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 10, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 9, mod.TileType("FortuneOreTile"));
                    WorldGen.PlaceTile(posX, posY - 6, mod.TileType("FortuneOreTile"));
                }
                FracturedSkiesWorld.usedKey = true;
            }
            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int i = Main.rand.Next(0, Main.maxTilesX);
                int j = Main.rand.Next(0, Main.maxTilesY);

                if (Main.tile[i, j].active())
                {
                    int type = (int)Main.tile[i, j].type;
                    if (type == TileID.BlueDungeonBrick || type == TileID.GreenDungeonBrick || type == TileID.PinkDungeonBrick)
                    {
                        WorldGen.TileRunner(i, j, WorldGen.genRand.Next(6, 12), WorldGen.genRand.Next(4, 6), mod.TileType("FortuneOreTile"), false, 0f, 0f, false, true);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
	}
}