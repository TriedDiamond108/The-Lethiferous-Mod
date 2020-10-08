using Terraria;
using Terraria.ModLoader;

namespace TheLethiferous.Projectiles
{
	public class LethiferousOrb : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cosmic Wave"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.width = 64;
			projectile.height = 64;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 4;
			projectile.melee = true;
			projectile.damage = 480;
			projectile.timeLeft = 250;
			projectile.arrow = false;
		}

		public override void ModifyHitPlayer( Player target, ref int damage, ref bool crit )
        {
        target.AddBuff(mod.BuffType("Death"), 560);
        }
        public override void ModifyHitNPC( NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection )
        {
        target.AddBuff(mod.BuffType("Death"), 560);
        }
	}
}