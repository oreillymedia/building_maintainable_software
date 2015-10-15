using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes {

    // tag::DutchFlag[]
    public class DutchFlag : Flag {
        public IList<Color> getColors() {
            return new List<Color>{ Color.Red, Color.White, Color.Red };
        }
    }
    // end::DutchFlag[]

}