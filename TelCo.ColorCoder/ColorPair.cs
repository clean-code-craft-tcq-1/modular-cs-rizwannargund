using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TeleCommunication.ColorCoder
{
    public partial class ColorPair
    {
        internal Color MajorColor { get; set; }
        internal Color MinorColor { get; set; }
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }

        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = ColorMap.Minor.Length;
            int majorSize = ColorMap.Major.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            ColorPair pair = new ColorPair()
            {
                MajorColor = ColorMap.Major[majorIndex],
                MinorColor = ColorMap.Minor[minorIndex]
            };

            return pair;
        }
    }
}
