using System;
using System.Collections.Generic;
using System.Text;

namespace TeleCommunication.ColorCoder
{
    public partial class ColorPair
    {
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
