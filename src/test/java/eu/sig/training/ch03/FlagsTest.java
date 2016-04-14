package eu.sig.training.ch03;

import static org.junit.Assert.assertEquals;

import java.awt.Color;
import java.util.List;

import org.junit.Test;

public class FlagsTest {

    @Test
    public void testGetFlag() {
        FlagFactory factory = new FlagFactory();

        List<Color> colors = factory.getFlagColors(Nationality.DUTCH);

        assertEquals(Color.RED, colors.get(0));
        assertEquals(Color.WHITE, colors.get(1));
        assertEquals(Color.BLUE, colors.get(2));
    }

}