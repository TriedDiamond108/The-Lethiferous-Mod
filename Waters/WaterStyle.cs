using TheLethiferous.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace TheLethiferous.Waters
{
	public class WaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
			=> Main.bgStyle == mod.GetSurfaceBgStyleSlot("WaterBgStyle");

		public override int ChooseWaterfallStyle() 
			=> mod.GetWaterfallStyleSlot("WaterfallStyle");

		public override int GetSplashDust() 
			=> DustType<WaterSplash>();

		public override int GetDropletGore() 
			=> mod.GetGoreSlot("Gores/Droplet");

		public override void LightColorMultiplier(ref float r, ref float g, ref float b) {
			r = 0f;
			g = 0f;
			b = 0.3f;
		}

		public override Color BiomeHairColor() 
			=> Color.Blue;
	}
}