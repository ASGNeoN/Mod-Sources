using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.NPCs.ModGlobalNPC
{
    public class ModGlobalNPC : GlobalNPC
    {
		public override bool PreNPCLoot(NPC npc)
		{
			if (npc.type == 398)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CelestialDie"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PortalGun);
				if (Main.rand.Next(7) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.BossMaskMoonlord, 1);
				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LunarOre, Main.rand.Next(70, 90));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GreaterHealingPotion, Main.rand.Next(5, 15));
				if(Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MoonLordTrophy, 1);
				}
				Main.NewText("Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn...", 255, 0, 0, false);
				return false;
			}
			if (npc.type != 398)
			{
				return true;
			}
			return false;
		}
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(1) == 0)
            {
				if (npc.type == 4)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OpticFragment"));
                }
				if (npc.type == 13 && npc.type == 14 && npc.type == 15)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForbiddenFragment"));
                }
				if (npc.type == NPCID.BrainofCthulhu)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForbiddenFragment"));
                }
                if (npc.type == NPCID.KingSlime)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SlimyFragment"));
                }
				if (npc.type == NPCID.QueenBee)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HoneyedFragment"));
                }
				if (npc.type == 68)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MagicKey"));
                }
				/*if (npc.type == 398)
                {
					if (Item.NewItem(/*(int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, *//*ItemID == 3063 || ItemID == 3389 || ItemID == 3065 || ItemID == 1553 || ItemID == 3546 || ItemID == 3541 || ItemID == 3570 || ItemID == 3571 || ItemID == 3569))
					{
						
					}
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CelestialDie"));
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PortalGun);
					if (Main.rand.Next(7) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.BossMaskMoonlord, 1);
					}
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LunarOre, Main.rand.Next(70, 90));
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GreaterHealingPotion, Main.rand.Next(5, 15));
					if(Main.rand.Next(10) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MoonLordTrophy, 1);
					}
					Main.NewText("Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn...", 255, 0, 0, false);
				}*/
            }
        }
		
		public override void SetupTravelShop(int[] shop, ref int nextSlot)
		{
			shop[nextSlot] = mod.ItemType("PhotonBlaster");
			//shop[nextSlot].value = 5000;
			nextSlot++;
			/*shop[nextSlot] = mod.ItemType("PhotonBlaster");
			shop[nextSlot].item.SetDefaults(mod.ItemType("PhotonBlaster"));
			shop[nextSlot].item.value = 5000;
			nextSlot++;*/
		}
    }
}