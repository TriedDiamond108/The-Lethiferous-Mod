using Terraria.ID;
using Terraria.ModLoader;

namespace TheLethiferous.Items
{
	public class DeathsRelease : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Death's Release"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("An unholy spear coming straight from the depths of the underworld.");
		}

		public override void SetDefaults() 
		{
			item.damage = 1560;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 8;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("DeathsReleaseProjectile");
			item.shootSpeed = 22f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 99);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}