using Terraria;
using Terraria.ModLoader;

namespace TheLethiferous.Projectiles
{
	public class StingerBall : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stinger Ball"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.width = 52;
			projectile.height = 52;
			projectile.aiStyle = 14;
			projectile.friendly = true;
			projectile.penetrate = 18;
			projectile.melee = true;
			projectile.damage = 20;
			projectile.timeLeft = 250;
			projectile.arrow = false;
		}
	}
}