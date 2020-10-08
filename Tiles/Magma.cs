using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheLethiferous.Tiles
{
	public class Magma : ModTile
	{
	    public override void SetDefaults()
		{
	        Main.tileSolid[Type] = true;
		    Main.tileMergeDirt[Type] = true;
		    Main.tileLighted[Type] = true;

			drop = mod.ItemType("MagmaBlock");

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Magma");
			AddMapEntry(new Color(255, 20, 20), name);

			minPick = 210;
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 0.1f;
			b = 0.1f;
		}
	}
}