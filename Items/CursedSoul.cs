using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class CursedSoul : ModItem
	{

	    public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Soul");
		}


		public override void SetDefaults()
		{
		     item.width = 18;
			 item.height = 18;
			 item.value = Item.sellPrice(silver: 15);
			 item.rare = ItemRarityID.Green;
		}
	}
}