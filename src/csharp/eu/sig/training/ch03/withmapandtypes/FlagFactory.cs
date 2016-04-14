using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes
{

    public class FlagFactory
    {

        // tag::getFlag[]
        private static readonly Dictionary<Nationality, IFlag> FLAGS =
            new Dictionary<Nationality, IFlag>();

        static FlagFactory()
        {
            FLAGS[Nationality.DUTCH] = new DutchFlag();
            FLAGS[Nationality.GERMAN] = new GermanFlag();
            FLAGS[Nationality.BELGIAN] = new BelgianFlag();
            FLAGS[Nationality.FRENCH] = new FrenchFlag();
            FLAGS[Nationality.ITALIAN] = new ItalianFlag();
        }

        public IList<Color> GetFlagColors(Nationality nationality)
        {
            IFlag flag = FLAGS[nationality];
            flag = flag ?? new DefaultFlag();
            return flag.Colors;
        }
        // end::getFlag[]

    }

}
