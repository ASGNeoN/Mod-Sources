using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items.Loot
{
	public class FortuneOre : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fortune Ore");
            Tooltip.SetDefault("Some treasure stolen from the Dungeon");
        }
        public override void SetDefaults()
		{
			item.width = 14;
			item.height = 14;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.consumable = true;
			item.createTile = mod.TileType("FortuneOreTile");
			item.maxStack = 999;
		}
	}
}