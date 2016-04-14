using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03
{
    public class FlagFactoryOops
    {
        public IList<Color> GetFlagColors(Nationality nationality)
        {
            List<Color> result;
            switch (nationality)
            {
                // tag::getFlag[]
                case Nationality.DUTCH:
                    result = new List<Color> { Color.Red, Color.White, Color.Blue };
                    // end::getFlag[]
                    break;
                // tag::getFlag[]
                case Nationality.LUXEMBOURGER:
                    result = new List<Color> { Color.Red, Color.White, Color.LightBlue };
                    break;
                case Nationality.GERMAN:
                    // end::getFlag[]
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

    }
}
