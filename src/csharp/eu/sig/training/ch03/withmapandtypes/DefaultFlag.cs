using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes
{
    public class DefaultFlag : IFlag
    {
        public IList<Color> Colors
        {
            get
            {
                return new List<Color> { Color.Gray };
            }
        }
    }
}
