using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.NPCs.ModGlobalNPC
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(1) == 0)
            {
				if (npc.type == 4)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OpticFragment"));
                }
/*				if (npc.type == NPCID.EaterOfWorlds)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForbiddenFragment"));
                }
				if (npc.type == NPCID.BrainOfCthulhu)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForbiddenFragment"));
                }*/
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
            }
        }
    }
}