using System.Drawing;
using System.Collections.Generic;

namespace eu.sig.training.ch03.withmapandtypes
{

    public class BelgianFlag : Flag {
        public IList<Color> getColors() {
            return new List<Color>{ Color.Black, Color.Red, Color.Yellow };
        }
    }
}