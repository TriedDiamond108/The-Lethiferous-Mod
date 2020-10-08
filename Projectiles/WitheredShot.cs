using Terraria;
using Terraria.ModLoader;

namespace TheLethiferous.Projectiles
{
	public class WitheredShot : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Withered Shot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.magic = true;
			projectile.damage = 15;
			projectile.timeLeft = 250;
			projectile.arrow = false;
		}

		public override void ModifyHitPlayer( Player target, ref int damage, ref bool crit )
        {
        target.AddBuff( mod.BuffType( "Withering" ), 240 );
        }
        public override void ModifyHitNPC( NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection )
        {
        target.AddBuff( mod.BuffType( "Withering" ), 240 );
        }
	}
}