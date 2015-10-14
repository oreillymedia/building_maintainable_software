package eu.sig.training.ch03.withmapandtypes;

import java.awt.Color;
import java.util.Arrays;
import java.util.List;

// tag::ItalianFlag[]
public class ItalianFlag implements Flag {
    public List<Color> getColors() {
        return Arrays.asList(Color.GREEN, Color.WHITE, Color.RED);
    }
}
// end::ItalianFlag[]