using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheLethiferous.Items
{
	public class EnchantedCrystal : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blue Ice"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Simply an odd looking crystal.");
		}

		public override void SetDefaults() 
		{
			item.width = 26;
			item.height = 26;
			item.maxStack = 20;
			item.rare = 4;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.consumable = true;
		}


		public override bool CanUseItem(Player player) 
		{
			return !NPC.AnyNPCs(mod.NPCType("RogueCrystal"));
		}


		public override bool UseItem(Player player)
		{
			Main.PlaySound(SoundID.Roar, player.position);
			if(Main.netMode != 1)
			{
				NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("RogueCrystal"));
			}
			return true;
		}
	}
}