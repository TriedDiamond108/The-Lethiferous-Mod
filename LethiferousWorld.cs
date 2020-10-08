using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.ModLoader.IO;
using System.IO;

namespace TheLethiferous
{
	public class LethiferousWorld : ModWorld
	{
		public static bool DownedRogueCrystal = false;
	    public static bool DownedWaspKing = false;
		public static bool DownedSandSharkTitan = false;
		public static bool DownedAngeloRock = false;
		
		

		public override void Initialize() 
		{
		    DownedRogueCrystal = false;
			DownedWaspKing = false;
			DownedSandSharkTitan = false;
			DownedAngeloRock = false;
		}


		public override TagCompound Save() 
		{
			var Downed = new List<string>();
			if (DownedRogueCrystal) Downed.Add("RogueCrystal");
			{

			if (DownedWaspKing) Downed.Add("WaspKing");
			{
            
			if (DownedSandSharkTitan) Downed.Add("SandSharkTitan");
			{
			
			if (DownedAngeloRock) Downed.Add("AngeloRock");
			}

			return new TagCompound
		    {
		        {
			        "Version", 0
			    },
			    {
				    "Downed", Downed
			    }
		    };
	    }
}
}

		public override void Load(TagCompound tag)
		{
			var Downed = tag.GetList<string>("Downed");
			DownedRogueCrystal = Downed.Contains("RogueCrystal");
		    DownedWaspKing = Downed.Contains("WaspKing");
			DownedSandSharkTitan = Downed.Contains("SandSharkTitan");
			DownedAngeloRock = Downed.Contains("AngeloRock");
		}


		public override void LoadLegacy(BinaryReader reader)
		{
			int loadVersion = reader.ReadInt32();
			if(loadVersion == 0)
			{
				BitsByte flags = reader.ReadByte();
				DownedRogueCrystal = flags[0];
				DownedWaspKing = flags[1];
				DownedSandSharkTitan = flags[2];
				DownedAngeloRock = flags[3];
			}
		}


		public override void NetSend(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = DownedRogueCrystal;
			flags[1] = DownedWaspKing;
			flags[2] = DownedSandSharkTitan;
			flags[3] = DownedAngeloRock;

			writer.Write(flags);
		}


		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			DownedRogueCrystal = flags[0];
			DownedWaspKing = flags[1];
			DownedSandSharkTitan = flags[2];
			DownedAngeloRock = flags[3];
		}
    }
}