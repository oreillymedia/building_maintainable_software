package eu.sig.training.ch03;

import java.awt.Color;
import java.util.Arrays;
import java.util.List;

public class Flag {
    private final List<Color> colors;

    public Flag(Color... colors) {
        this.colors = Arrays.asList(colors);
    }

    public List<Color> getColors() {
        return colors;
    }
}