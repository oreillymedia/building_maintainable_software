using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes {

    public class FlagFactory {

        // tag::getFlag[]
        private static readonly Dictionary<Nationality, Flag> FLAGS =
            new Dictionary<Nationality, Flag> ();

        static FlagFactory() {
            FLAGS [Nationality.DUTCH] = new DutchFlag ();
            FLAGS [Nationality.GERMAN] = new GermanFlag ();
            FLAGS [Nationality.BELGIAN] = new BelgianFlag ();
            FLAGS [Nationality.FRENCH] = new FrenchFlag ();
            FLAGS [Nationality.ITALIAN] = new ItalianFlag ();
        }

        public IList<Color> getFlagColors(Nationality nationality) {
            Flag flag = FLAGS [nationality];
            flag = flag != null ? flag : new DefaultFlag ();
            return flag.getColors ();
        }
        // end::getFlag[]

    }

}