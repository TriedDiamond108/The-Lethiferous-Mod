using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.NPCs.Enemies
{
	public class RedPaperWasp : ModNPC
	{
		public override void SetStaticDefaults() 
		{
		     DisplayName.SetDefault("Red Paper Wasp");
			 Main.npcFrameCount[npc.type] = 2;
		}


		public override void SetDefaults() 
		{
			npc.width = 18;
			npc.height = 18; 
			npc.lifeMax = 600;
			npc.damage = 55;
			npc.defense = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 10f;
			npc.knockBackResist = 0.35f;
			npc.aiStyle = 14;
			animationType = 0;
			banner = Item.NPCtoBanner(NPCID.Hornet);
			bannerItem = Item.BannerToItem(banner);
		}


		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.UndergroundJungle.Chance * 0.025f;
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