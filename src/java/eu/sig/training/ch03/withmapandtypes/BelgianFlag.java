package eu.sig.training.ch03.withmapandtypes;

import java.awt.Color;
import java.util.Arrays;
import java.util.List;

public class BelgianFlag implements Flag {
    public List<Color> getColors() {
        return Arrays.asList(Color.BLACK, Color.RED, Color.YELLOW);
    }
}