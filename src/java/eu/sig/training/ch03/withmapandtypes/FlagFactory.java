package eu.sig.training.ch03.withmapandtypes;

import static eu.sig.training.ch03.Nationality.BELGIAN;
import static eu.sig.training.ch03.Nationality.DUTCH;
import static eu.sig.training.ch03.Nationality.FRENCH;
import static eu.sig.training.ch03.Nationality.GERMAN;
import static eu.sig.training.ch03.Nationality.ITALIAN;

import java.awt.Color;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import eu.sig.training.ch03.Nationality;

public class FlagFactory {

    // tag::getFlag[]
    private static final Map<Nationality, Flag> FLAGS =
        new HashMap<Nationality, Flag>();

    static {
        FLAGS.put(DUTCH, new DutchFlag());
        FLAGS.put(GERMAN, new GermanFlag());
        FLAGS.put(BELGIAN, new BelgianFlag());
        FLAGS.put(FRENCH, new FrenchFlag());
        FLAGS.put(ITALIAN, new ItalianFlag());
    }

    public List<Color> getFlagColors(Nationality nationality) {
        Flag flag = FLAGS.get(nationality);
        flag = flag != null ? flag : new DefaultFlag();
        return flag.getColors();
    }
    // end::getFlag[]

}