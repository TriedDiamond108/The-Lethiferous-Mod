using Terraria;
using Terraria.ModLoader;

namespace TheLethiferous.Buffs
{
	public class Death : ModBuff
	{
		public override void SetDefaults() 
		{
			DisplayName.SetDefault("Death");
			Description.SetDefault("Your demise awaits you");
		}


		public override void Update(Player player, ref int buffIndex) 
		{
			player.lifeRegen -= 50;
			player.meleeDamage -= 10f;
			player.rangedDamage -= 10f;
			player.thrownDamage -= 10f;
			player.magicDamage -= 10f;
			player.minionDamage -= 10f;
		}

	}
}