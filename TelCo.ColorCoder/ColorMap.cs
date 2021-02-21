using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TeleCommunication.ColorCoder
{
    public static class ColorMap
    {
        public static Color[] Major;
     
        public static Color[] Minor;

        static ColorMap()
        {
            Major = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            Minor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
