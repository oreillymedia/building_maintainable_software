using System.Drawing;
using System.Collections.Generic;

namespace eu.sig.training.ch03.withmapandtypes
{

    // tag::Flag[]
    public interface IFlag
    {
        IList<Color> Colors { get; }
    }
    // end::Flag[]

}
