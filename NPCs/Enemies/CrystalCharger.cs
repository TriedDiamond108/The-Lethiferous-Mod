using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.NPCs.Enemies
{
	public class CrystalCharger : ModNPC
	{
		public override void SetStaticDefaults() 
		{
		     DisplayName.SetDefault("Crystal Charger");
			 Main.npcFrameCount[npc.type] = 1;
		}


		public override void SetDefaults() 
		{
			npc.width = 20;
			npc.height = 20; 
			npc.lifeMax = 100;
			npc.damage = 20;
			npc.defense = 1;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 10f;
			npc.knockBackResist = 0.15f;
			npc.aiStyle = 63;
			animationType = 0;
			banner = Item.NPCtoBanner(NPCID.BlueSlime);
			bannerItem = Item.BannerToItem(banner);
		}


		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySnowCritter.Chance * 0.025f;
		}


		public override void NPCLoot()
		{
			Item.NewItem(npc.position, mod.ItemType("CrystalShard"));
			if(Main.rand.Next(2) == 0)
			{
				Item.NewItem(npc.position, mod.ItemType("CrystalShard"));
			}
			if(Main.rand.Next(4) == 0)
			{
				Item.NewItem(npc.position, mod.ItemType("CrystalShard"));
			}
		}
	}
}