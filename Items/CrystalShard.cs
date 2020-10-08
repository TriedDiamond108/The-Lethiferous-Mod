using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class CrystalShard : ModItem
	{

	    public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Shard");
		}


		public override void SetDefaults()
		{
		     item.width = 18;
			 item.height = 18;
			 item.value = Item.sellPrice(silver: 30);
			 item.rare = ItemRarityID.Green;
		}
	}
}