using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes
{

    // tag::DutchFlag[]
    public class DutchFlag : IFlag
    {
        public IList<Color> Colors
        {
            get
            {
                return new List<Color> { Color.Red, Color.White, Color.Blue };
            }
        }
    }
    // end::DutchFlag[]
}
