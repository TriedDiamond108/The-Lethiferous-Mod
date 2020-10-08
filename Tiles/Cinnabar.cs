using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheLethiferous.Tiles
{
	public class Cinnabar : ModTile
	{
	    public override void SetDefaults()
		{
	        Main.tileSolid[Type] = true;
		    Main.tileMergeDirt[Type] = true;
		    Main.tileLighted[Type] = true;

			drop = mod.ItemType("CinnabarBlock");

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cinnabar");
			AddMapEntry(new Color(120, 0, 0), name);

			minPick = 110;
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.0f;
			b = 0.0f;
		}
	}
}