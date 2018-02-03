using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FracturedSkies.NPCs.Bosses
{
    public class WaspKing : ModNPC
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Wasp King");
            Main.npcFrameCount[npc.type] = 12; // make sure to set this for your modnpcs.
        }
        public override void SetDefaults()
		{
			npc.aiStyle = 43;
			npc.lifeMax = 100;   //boss life
			npc.damage = 20;  //boss damage
			npc.defense = 10;    //boss defense
			npc.knockBackResist = 0f;
			npc.width = 100;
			npc.height = 100;
			animationType = NPCID.QueenBee;   //this boss will have behavior like the Queen Bee
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
		}
        bool summonText = false;
        public override bool PreAI()
        {
            if (summonText == false)
            {
                Main.NewText("The Wasp King has awoken", 175, 75, 255, false);
                summonText = true;
            }
                return true;
        }
		/*public override void PostAI()
		{
		}*/
	}
}