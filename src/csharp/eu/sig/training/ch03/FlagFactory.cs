using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03
{

    public class FlagFactory
    {
        // tag::getFlag[]
        public IList<Color> GetFlagColors(Nationality nationality)
        {
            List<Color> result;
            switch (nationality)
            {
                case Nationality.DUTCH:
                    result = new List<Color> { Color.Red, Color.White, Color.Blue };
                    break;
                case Nationality.GERMAN:
                    result = new List<Color> { Color.Black, Color.Red, Color.Yellow };
                    break;
                case Nationality.BELGIAN:
                    result = new List<Color> { Color.Black, Color.Yellow, Color.Red };
                    break;
                case Nationality.FRENCH:
                    result = new List<Color> { Color.Blue, Color.White, Color.Red };
                    break;
                case Nationality.ITALIAN:
                    result = new List<Color> { Color.Green, Color.White, Color.Red };
                    break;
                case Nationality.UNCLASSIFIED:
                default:
                    result = new List<Color> { Color.Gray };
                    break;
            }
            return result;
        }
        // end::getFlag[]
    }

}
