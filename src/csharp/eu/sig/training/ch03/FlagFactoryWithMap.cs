using System.Drawing;
using System.Collections.Generic;

namespace eu.sig.training.ch03
{

    public class FlagFactoryWithMap
    {

        // tag::getFlag[]
        private static Dictionary<Nationality, IList<Color>> FLAGS =
            new Dictionary<Nationality, IList<Color>>();

        static FlagFactoryWithMap()
        {
            FLAGS[Nationality.DUTCH] = new List<Color>{ Color.Red, Color.White,
                Color.Blue };
            FLAGS[Nationality.GERMAN] = new List<Color>{ Color.Black, Color.Red,
                Color.Yellow };
            FLAGS[Nationality.BELGIAN] = new List<Color>{ Color.Black, Color.Yellow,
                Color.Red };
            FLAGS[Nationality.FRENCH] = new List<Color>{ Color.Blue, Color.White,
                Color.Red };
            FLAGS[Nationality.ITALIAN] = new List<Color>{ Color.Green, Color.White,
                Color.Red };
        }

        public IList<Color> GetFlagColors(Nationality nationality)
        {
            IList<Color> colors = FLAGS[nationality];
            return colors ?? new List<Color> { Color.Gray };
        }
        // end::getFlag[]
    }
}
