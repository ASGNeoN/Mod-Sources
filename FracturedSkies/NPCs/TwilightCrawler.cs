using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FracturedSkies.NPCs
{
    public class TwilightCrawler : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twilight Crawler");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
        }

        public override void SetDefaults()
        {
            npc.width = 54;
            npc.height = 24;
            npc.damage = 40;
            npc.defense = 18;
            npc.lifeMax = 800;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath16;
            npc.value = 200f;
            npc.knockBackResist = 0.8f;
            npc.aiStyle = 1;
            aiType = NPCID.Zombie;
            //animationType = NPCID.Zombie;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (FracturedSkiesWorld.downedCthulhu1)
            {
                return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
            }
            return 0;
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TwilightBone"));
        }
    }
}
