using System;
using System.Collections.Generic;
using System.Text;

namespace TeleCommunication.ColorCoder
{
    public partial class ColorPair
    {
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

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1, minorIndex = -1;
            for (int i = 0; i < ColorMap.Major.Length; i++)
            {
                if (ColorMap.Major[i] == pair.MajorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            for (int i = 0; i < ColorMap.Minor.Length; i++)
            {
                if (ColorMap.Minor[i] == pair.MinorColor)
                {
                    minorIndex = i;
                    break;
                }
            }

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            return (majorIndex * ColorMap.Minor.Length) + (minorIndex + 1);
        }
    }
}
