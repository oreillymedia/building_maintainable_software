using System.Drawing;
using System.Collections.Generic;

namespace eu.sig.training.ch03
{

    public class Flag
    {
        public IList<Color> Colors { get; }

        public Flag(params Color[] colors)
        {
            Colors = new List<Color>(colors);
        }
    }
}
