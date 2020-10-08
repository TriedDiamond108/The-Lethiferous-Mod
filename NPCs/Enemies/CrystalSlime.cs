using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.NPCs.Enemies
{
	public class CrystalSlime : ModNPC
	{
		public override void SetStaticDefaults() 
		{
		     DisplayName.SetDefault("Crystal Slime");
			 Main.npcFrameCount[npc.type] = 13;
		}


		public override void SetDefaults() 
		{
			npc.width = 40;
			npc.height = 30; 
			npc.lifeMax = 265;
			npc.damage = 60;
			npc.defense = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 20f;
			npc.knockBackResist = 0.75f;
			npc.aiStyle = 1;
			animationType = 0;
			banner = Item.NPCtoBanner(NPCID.BlueSlime);
			bannerItem = Item.BannerToItem(banner);
		}


		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySnowCritter.Chance * 0.1f;
		}


		public override void NPCLoot()
		{
			Item.NewItem(npc.position, ItemID.Gel, 2);
			if(Main.rand.Next(2) == 0)
			{
				Item.NewItem(npc.position, mod.ItemType("CrystalShard"));
			}
			if(Main.rand.Next(9999) == 0)
			{
				Item.NewItem(npc.position, mod.ItemType("ObsidianClaymore"));
			}
		}
	}
}