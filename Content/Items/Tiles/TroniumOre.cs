using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ID.ContentSamples.CreativeHelper;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace TroniumMod.Content.Items.Tiles
{
    public class TroniumOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
            Main.tileOreFinderPriority[Type] = 1; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
            Main.tileShine2[Type] = true; // Modifies the draw color slightly.
            Main.tileShine[Type] = 200; // How often tiny dust appear off this tile. Larger is less frequently
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Tronium Ore");
            AddMapEntry(new Color(240, 65, 65), name);

            DustType = 69;
            ItemDrop = ModContent.ItemType<Placeable.TroniumOre>();
            HitSound = SoundID.Tink;
            // MineResist = 4f;
            // MinPick = 200;
        }
    }

    
}
