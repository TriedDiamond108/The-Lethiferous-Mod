using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class BlackWing : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Black Wing"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.rare = ItemRarityID.Pink;
			item.value = Item.sellPrice(gold: 10);
			item.maxStack = 999;
		}
	}
}