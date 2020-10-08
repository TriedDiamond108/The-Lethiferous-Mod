using Terraria;
using Terraria.ModLoader;

namespace TheLethiferous.Projectiles
{
	public class DeathsReleaseProjectile : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Death's Release"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
			projectile.width = 32;
			projectile.height = 8;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.melee = true;
			projectile.damage = 1560;
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