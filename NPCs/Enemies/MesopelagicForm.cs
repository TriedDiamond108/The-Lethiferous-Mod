using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.NPCs.Enemies
{
	public class MesopelagicForm : ModNPC
	{
		public override void SetStaticDefaults() 
		{
		     DisplayName.SetDefault("Mesopelagic Form");
			 Main.npcFrameCount[npc.type] = 10;
		}


		public override void SetDefaults() 
		{
			npc.width = 40;
			npc.height = 20; 
			npc.lifeMax = 800;
			npc.damage = 40;
			npc.defense = 15;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 10f;
			npc.knockBackResist = 0.15f;
			npc.aiStyle = 16;
			animationType = 0;
			banner = Item.NPCtoBanner(NPCID.BlueSlime);
			bannerItem = Item.BannerToItem(banner);
		}


		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OceanMonster.Chance * 0.001f;
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