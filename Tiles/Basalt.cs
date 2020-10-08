using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheLethiferous.Tiles
{
	public class Basalt : ModTile
	{
	    public override void SetDefaults()
		{
	        Main.tileSolid[Type] = true;
		    Main.tileMergeDirt[Type] = true;
		    Main.tileLighted[Type] = true;

			drop = mod.ItemType("BasaltBlock");

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Basalt");
			AddMapEntry(new Color(25, 25, 25), name);

			minPick = 210;
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.1f;
			g = 0.1f;
			b = 0.1f;
		}
	}
}