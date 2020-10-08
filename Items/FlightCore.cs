using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class FlightCore : ModItem
	{

	    public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flight Core");
		}


		public override void SetDefaults()
		{
		     item.width = 18;
			 item.height = 18;
			 item.value = Item.sellPrice(gold: 50);
			 item.rare = ItemRarityID.Orange;
		}
	}
}