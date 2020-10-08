using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheLethiferous.Tiles
{
	public class Azurite : ModTile
	{
	    public override void SetDefaults()
		{
	        Main.tileSolid[Type] = true;
		    Main.tileMergeDirt[Type] = true;
		    Main.tileLighted[Type] = true;

			drop = mod.ItemType("AzuriteBlock");

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Azurite");
			AddMapEntry(new Color(0, 45, 255), name);

			minPick = 110;
        }
		
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.0f;
			g = 0.0f;
			b = 1f;
		}
	}
}