using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TeleCommunication.ColorCoder
{
    public class ColorPair
    {
        internal Color MajorColor { get; set; }
        internal Color MinorColor { get; set; }
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }

        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
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

        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColorMap.Major.Length; i++)
            {
                if (ColorMap.Major[i] == pair.MajorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            int minorIndex = -1;
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

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorMap.Minor.Length) + (minorIndex + 1);
        }
    }
}
