using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes
{

    // tag::ItalianFlag[]
    public class ItalianFlag : IFlag
    {
        public IList<Color> Colors
        {
            get
            {
                return new List<Color> { Color.Green, Color.White, Color.Red };
            }
        }
    }
    // end::ItalianFlag[]

}
