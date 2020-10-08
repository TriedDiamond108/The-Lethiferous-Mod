 using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System;

namespace TheLethiferous.NPCs.Bosses
{

    [AutoloadBossHead]

	public class SandSharkTitan : ModNPC
	{
		private int ai;
		private int attackTimer = 0;
		private bool fastSpeed = false;

		private bool stunned;
		private int stunnedTimer;


		private int frame = 0;
		private double counting;


		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sand Shark Titan");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults() 
		{
			npc.width = 20;
			npc.height = 248;
			
			npc.boss = true;
			npc.aiStyle = 6;
			npc.npcSlots = 5f;
			
			npc.lifeMax = 1260;
			npc.damage = 20;
			npc.defense = 10;
			npc.knockBackResist = 0f;

			npc.value = Item.buyPrice(gold: 15);

			npc.lavaImmune = true;
			npc.noTileCollide = true;
			npc.noGravity = true;

			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			music = MusicID.Boss4;

			bossBag = mod.ItemType("SandSharkTreasureBag");
		}


		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax * bossLifeScale);
			npc.damage = (int)(npc.damage * 1.75f);
		}


		public override void FindFrame(int frameHeight)
		{
			if(frame == 0)
			{
				counting += 1.0;
				if(counting < 8.0)
				{
					npc.frame.Y = 0;
				} else if(counting < 16.0)
				{
					npc.frame.Y = frameHeight;
				} else if(counting < 24.0)
				{
					npc.frame.Y = frameHeight * 2;
				} else if(counting < 32.0)
				{
				    npc.frame.Y = frameHeight * 3;
				} else
				{
					counting = 0.0;
				}
			}
			else if (frame == 1)
			{
				npc.frame.Y = frameHeight * 4;
			}
		}


	private void MoveTowards(NPC npc, Vector2 playerTarget, float speed, float turnResistance)
	{
		var move = playerTarget - npc.Center;
		float length = move.Length();
		if(length > speed)
		{
			move *= speed / length;
		}
		move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
		length = move.Length();
		if(length > speed)
		{
			move *= speed / length;
		}
		npc.velocity=move;
	}


	public override void NPCLoot()
	{
		LethiferousWorld.DownedSandSharkTitan = true;
		if(Main.expertMode)
		{
			npc.DropBossBags();
		} else
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(1, 3));
		}
	}


	public override void BossLoot(ref string name, ref int potionType)
	{
	    potionType = ItemID.HealingPotion;
	}	
}
}