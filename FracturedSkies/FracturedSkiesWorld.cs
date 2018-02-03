using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace FracturedSkies
{
    public class FracturedSkiesWorld : ModWorld
    {
		private const int saveVersion = 0;
		public static bool downedCthulhu1 = false;
        public static bool downedCthulhu2 = false;
		public static bool usedKey = false;
        //public static bool Apocalypse = false;

        public override void Initialize()
		{
			downedCthulhu1 = false;
			downedCthulhu2 = false;
			usedKey = false;
            //Apocalypse = false;
        }

		public override TagCompound Save()
		{
			var downed = new List<string>();
            var consumed = new List<string>();
            if (downedCthulhu1) downed.Add("Cthulhu1");
			if (downedCthulhu2) downed.Add("Cthulhu2");
            if (usedKey) consumed.Add("usedKey");
            //if (Apocalypse) .Add("Apocalypse");

            return new TagCompound {
                {"downed", downed},
                {"used", consumed }
            };
		}

		public override void Load(TagCompound tag)
		{
			var downed = tag.GetList<string>("downed");
			downedCthulhu1 = downed.Contains("Cthulhu1");
			downedCthulhu2 = downed.Contains("Cthulhu2");
			
			var consumed = tag.GetList<string>("used");
			usedKey = consumed.Contains("usedKey");
		}
        
		public override void LoadLegacy(BinaryReader reader)
		{
			int loadVersion = reader.ReadInt32();
			if (loadVersion == 0)
			{
				BitsByte flags = reader.ReadByte();
				downedCthulhu1 = flags[0];
				downedCthulhu2 = flags[1];
				usedKey = flags[0];
			}
			else
			{
				ErrorLogger.Log("FracturedSkies: Unknown loadVersion: " + loadVersion);
			}
		}

		public override void NetSend(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = downedCthulhu1;
			flags[1] = downedCthulhu2;
			flags[0] = usedKey;
			writer.Write(flags);
		}

		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			downedCthulhu1 = flags[0];
			downedCthulhu2 = flags[1];
			usedKey = flags[0];
		}
    }
}