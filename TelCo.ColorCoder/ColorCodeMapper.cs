using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelCo.ColorCoder
{
    public class ColorCodeMapper
    {
        private Dictionary<int, ColorCode> colorCodeReferences;
        public ColorCodeMapper()
        {
            colorCodeReferences = new Dictionary<int, ColorCode>();
            int pairNumber = 1;
            for (int i = 0; i < ColorCode.MapMajor.Length; i++)
            {
                for (int j = 0; j < ColorCode.MapMinor.Length; j++)
                {
                    colorCodeReferences.Add(pairNumber, new ColorCode() { MajorColor = ColorCode.MapMajor[i], MinorColor = ColorCode.MapMinor[j] });
                    pairNumber++;
                }
            }
        }
        internal ColorCode GetColorCodeFromPairNumber(int pairNumber)
        {
            if (!colorCodeReferences.ContainsKey(pairNumber))
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            return colorCodeReferences[pairNumber];
        }
        internal int GetPairNumberFromColorCode(ColorCode pair)
        {
            if (!colorCodeReferences.Any(x => x.Value.MajorColor.Equals(pair.MajorColor) && x.Value.MinorColor.Equals(pair.MinorColor)))
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            return colorCodeReferences.FirstOrDefault(x => x.Value.MajorColor.Equals(pair.MajorColor) && x.Value.MinorColor.Equals(pair.MinorColor)).Key;
        }
    }
}
