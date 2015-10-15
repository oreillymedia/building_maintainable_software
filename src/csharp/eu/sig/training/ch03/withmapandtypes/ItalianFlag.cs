using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes {

    // tag::ItalianFlag[]
    public class ItalianFlag : Flag {
        public IList<Color> getColors() {
            return new List<Color>{ Color.Green, Color.White, Color.Red };
        }
    }
    // end::ItalianFlag[]

}