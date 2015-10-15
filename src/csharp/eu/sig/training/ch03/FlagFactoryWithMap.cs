using System.Drawing;
using System.Collections.Generic;

using eu.sig.training.ch03;

namespace eu.sig.training.ch03 {

    public class FlagFactoryWithMap {

        // tag::getFlag[]
        private static Dictionary<Nationality, IList<Color>> FLAGS =
            new Dictionary<Nationality, IList<Color>> ();

        static FlagFactoryWithMap() {
            FLAGS.Add (Nationality.DUTCH, new List<Color>{ Color.Red, Color.White, Color.Blue });
            FLAGS.Add (Nationality.GERMAN, new List<Color>{ Color.Black, Color.Red, Color.Yellow });
            FLAGS.Add (Nationality.BELGIAN, new List<Color>{ Color.Black, Color.Yellow, Color.Red });
            FLAGS.Add (Nationality.FRENCH, new List<Color>{ Color.Blue, Color.White, Color.Red });
            FLAGS.Add (Nationality.ITALIAN, new List<Color>{ Color.Green, Color.White, Color.Red });
        }

        public IList<Color> getFlagColors(Nationality nationality) {
            IList<Color> colors = FLAGS[nationality];
            return colors != null ? colors : new List<Color>{Color.Gray};
        }
        // end::getFlag[]

    }
}