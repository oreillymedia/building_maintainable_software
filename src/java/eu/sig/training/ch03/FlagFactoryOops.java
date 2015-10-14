package eu.sig.training.ch03;

import java.util.Arrays;
import java.util.List;

public class FlagFactoryOops {
    private static class Color extends java.awt.Color {
        private static final long serialVersionUID = 1L;
        public static Color BLACK = getColor(java.awt.Color.BLACK);
        public static Color BLUE = getColor(java.awt.Color.BLUE);
        public static Color RED = getColor(java.awt.Color.RED);
        public static Color GREEN = getColor(java.awt.Color.GREEN);
        public static Color GRAY = getColor(java.awt.Color.GRAY);
        public static Color LIGHT_BLUE = getColor(new java.awt.Color(0, 163, 224));
        public static Color WHITE = getColor(java.awt.Color.WHITE);
        public static Color YELLOW = getColor(java.awt.Color.YELLOW);

        public Color(java.awt.Color realColor) {
            super(realColor.getRGB());
        }

        public static Color getColor(java.awt.Color c) {
            return new Color(c);
        }
    }

    public List<Color> getFlagColors(Nationality nationality) {
        List<Color> result;
        switch (nationality) {
        // tag::getFlag[]    
        case DUTCH:
            result = Arrays.asList(Color.RED, Color.WHITE, Color.BLUE);
        case LUXEMBOURGER:
            result = Arrays.asList(Color.RED, Color.WHITE, Color.LIGHT_BLUE);
            break;
        case GERMAN:
            // end::getFlag[]        
            result = Arrays.asList(Color.BLACK, Color.RED, Color.YELLOW);
            break;
        case BELGIAN:
            result = Arrays.asList(Color.BLACK, Color.YELLOW, Color.RED);
            break;
        case FRENCH:
            result = Arrays.asList(Color.BLUE, Color.WHITE, Color.RED);
            break;
        case ITALIAN:
            result = Arrays.asList(Color.GREEN, Color.WHITE, Color.RED);
            break;
        case UNCLASSIFIED:
        default:
            result = Arrays.asList(Color.GRAY);
            break;
        }
        return result;
    }

}