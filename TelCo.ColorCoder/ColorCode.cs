using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    public class ColorCode
    {
        private static Color[] _mapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };

        public static Color[] MapMajor
        {
            get { return _mapMajor; }
            private set { _mapMajor = value; }
        }

        private static Color[] _mapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

        public static Color[] MapMinor
        {
            get { return _mapMinor; }
            private set { _mapMinor = value; }
        }

        public Color MajorColor { get; set; }

        public Color MinorColor { get; set; }

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }
    }
}
