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
    }
}
