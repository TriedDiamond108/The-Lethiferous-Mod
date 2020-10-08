using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheLethiferous.Items
{
	public class RogueCrystalTreasureBag : ModItem
	{

	    public override int BossBagNPC => mod.NPCType("RogueCrystal");


		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Treasure Bag"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("<right> to open");
		}

		public override void SetDefaults() 
		{
			item.width = 26;
			item.height = 26;
			item.maxStack = 999;
			item.rare = 9;
			item.consumable = true;
			item.expert = true;
		}


		public override void OpenBossBag(Player player) 
		{
			player.QuickSpawnItem(ItemID.GoldCoin, 50);
			player.QuickSpawnItem(ItemID.HealingPotion, 10);
			player.QuickSpawnItem(ItemID.GreaterHealingPotion, 30);
			if(Main.rand.Next(7) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("EnchantedBeryl"));
			}
			if(Main.rand.Next(50) == 0)
			{
				player.QuickSpawnItem(ItemID.DirtBlock, 5);
			}
		}
	}
}