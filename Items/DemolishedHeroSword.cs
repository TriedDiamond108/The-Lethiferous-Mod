using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class DemolishedHeroSword : ModItem
	{

	    public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demolished Hero Sword");
		}


		public override void SetDefaults()
		{
		     item.width = 18;
			 item.height = 18;
			 item.value = Item.sellPrice(gold: 25);
			 item.rare = ItemRarityID.Pink;
		}
	}
}