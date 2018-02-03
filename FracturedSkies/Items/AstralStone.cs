using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.Items
{
	public class AstralStone : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Stone");
            Tooltip.SetDefault("A bit of the cursed heavens");
        }
        public override void SetDefaults()
		{
			item.width = 14;
			item.height = 14;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 0;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.consumable = true;
			item.createTile = mod.TileType("AstralStoneTile");
			item.maxStack = 999;
		}
	}
}