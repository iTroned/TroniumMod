using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using TroniumMod.Content.Items.Tiles;

namespace TroniumMod.Common.Systems
{
    public class ToxCityBiomeTileCounter : ModSystem
    {
        public int exampleBlockCount;

        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            exampleBlockCount = tileCounts[ModContent.TileType<TroniumBar>()];
        }
    }
}
