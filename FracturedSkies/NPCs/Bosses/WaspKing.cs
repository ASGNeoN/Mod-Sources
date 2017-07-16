using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.NPCs.Bosses
{
	public class WaspKing : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Wasp King";
			npc.displayName = "The Wasp King";
			npc.aiStyle = 43;
			npc.lifeMax = 100;   //boss life
			npc.damage = 20;  //boss damage
			npc.defense = 10;    //boss defense
			npc.knockBackResist = 0f;
			npc.width = 100;
			npc.height = 100;
			animationType = NPCID.QueenBee;   //this boss will behavior like the DemonEye
			Main.npcFrameCount[npc.type] = 12;    //boss frame/animation 
			npc.value = Item.buyPrice(0, 1, 75, 45);
			npc.npcSlots = 1f;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit8;
			npc.DeathSound = SoundID.NPCDeath24;
			npc.buffImmune[24] = true;
			music = MusicID.Boss2;
			npc.netAlways = true;
			Main.NewText("The WaspKing has awoken", 175, 75, 255, false);
		}
        /*public override bool PreAI()
        {
			if (npc.ai[0] == 0)
			{
				Main.NewText("The WaspKing has awoken", 175, 75, 255, false);
				// We're setting npc.ai[0] to 1, so that this 'if' is not triggered again.
				npc.ai[0] = 43;
				npc.netUpdate = true;
			}
            return false;
        }*/
	}
}