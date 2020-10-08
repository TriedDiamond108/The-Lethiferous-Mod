using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class AzuriteBlock : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Azurite"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable= true;
			item.useStyle= 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.createTile = mod.TileType("Azurite");
			item.autoReuse = true;
		}
	}
}