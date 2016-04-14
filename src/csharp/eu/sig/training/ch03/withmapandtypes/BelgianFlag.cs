using System.Drawing;
using System.Collections.Generic;

namespace eu.sig.training.ch03.withmapandtypes
{

    public class BelgianFlag : IFlag
    {
        public IList<Color> Colors
        {
            get
            {
                return new List<Color> { Color.Black, Color.Red, Color.Yellow };
            }
        }
    }
}
