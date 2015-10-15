using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes {

    public class GermanFlag : Flag {
        public IList<Color> getColors() {
            return new List<Color>{ Color.Black, Color.Red, Color.Yellow };
        }
    }

}