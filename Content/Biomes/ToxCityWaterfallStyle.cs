using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace TroniumMod.Content.Biomes
{
    public class ToxCityWaterfallStyle : ModWaterfallStyle
    {
        public override void AddLight(int i, int j) =>
            Lighting.AddLight(new Vector2(i, j).ToWorldCoordinates(), Color.GreenYellow.ToVector3() * 0.5f);
    }
}
