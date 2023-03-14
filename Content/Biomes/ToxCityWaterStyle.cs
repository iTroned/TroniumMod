using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TroniumMod.Content.Biomes
{
    public class ToxCityWaterStyle : ModWaterStyle
    {
        public override int ChooseWaterfallStyle()
        {
            return ModContent.Find<ModWaterfallStyle>("TroniumMod/ToxCityWaterfallStyle").Slot;
        }

        public override int GetSplashDust()
        {
            return ModContent.DustType<Dusts.ToxCitySolution>();
        }

        public override int GetDropletGore()
        {
            return ModContent.Find<ModGore>("TroniumMod/MinionBossBody_Back").Type;
        }
            
        public override void LightColorMultiplier(ref float r, ref float g, ref float b)
        {
            r = 1f;
            g = 1f;
            b = 1f;
        }

        public override Color BiomeHairColor()
        {
            return Color.White;
        }

        public override byte GetRainVariant()
        {
            return (byte)Main.rand.Next(3);
        }

        public override Asset<Texture2D> GetRainTexture()
        {
            return ModContent.Request<Texture2D>("TroniumMod/Content/Biomes/ToxCityRain");
        }
    }
}
