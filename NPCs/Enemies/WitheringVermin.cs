using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.NPCs.Enemies
{
	public class WitheringVermin : ModNPC
	{
		public override void SetStaticDefaults() 
		{
		     DisplayName.SetDefault("Withering Vermin");
			 Main.npcFrameCount[npc.type] = 4;
		}


		public override void SetDefaults() 
		{
			npc.width = 20;
			npc.height = 32; 
			npc.lifeMax = 50;
			npc.damage = 20;
			npc.defense = 999;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 15f;
			npc.knockBackResist = 0.0f;
			npc.aiStyle = 19;
			animationType = 0;
			banner = Item.NPCtoBanner(NPCID.Hornet);
			bannerItem = Item.BannerToItem(banner);
		}


		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Corruption.Chance * 0.1f;
		}


		public override void NPCLoot()
		{
			Item.NewItem(npc.position, ItemID.ChlorophyteOre, 2);
			if(Main.rand.Next(3) == 0)
			{
				Item.NewItem(npc.position, mod.ItemType("BlackWing"));
			}
			if(Main.rand.Next(32) == 0)
			{
				Item.NewItem(npc.position, mod.ItemType("TatteredWaspWing"));
			}
		}
	}
}