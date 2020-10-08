using Terraria;
using Terraria.ModLoader;

namespace TheLethiferous.Projectiles
{
	public class AquaBullet : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Aqua Bullet"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.width = 30;
			projectile.height = 3;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
			projectile.timeLeft = 250;
			projectile.arrow = false;
		}
	}
}