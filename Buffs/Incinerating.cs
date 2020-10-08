using Terraria;
using Terraria.ModLoader;

namespace TheLethiferous.Buffs
{
	public class Incinerating : ModBuff
	{
		public override void SetDefaults() 
		{
			DisplayName.SetDefault("Incinerating");
			Description.SetDefault("Your flesh is being burned off");
		}


		public override void Update(Player player, ref int buffIndex) 
		{
			player.lifeRegen -= 5;
			player.meleeDamage -= 0.3f;
			player.rangedDamage -= 0.3f;
			player.thrownDamage -= 0.3f;
			player.magicDamage -= 0.3f;
			player.minionDamage -= 0.3f;
		}

	}
}