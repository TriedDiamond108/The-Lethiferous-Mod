using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class BasaltBlock : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Basalt"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
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
			item.createTile = mod.TileType("Basalt");
			item.autoReuse = true;
		}
	}
}