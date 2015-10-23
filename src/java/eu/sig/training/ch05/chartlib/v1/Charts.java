package eu.sig.training.ch05.chartlib.v1;

import java.awt.Graphics;
import java.awt.Point;

import eu.sig.training.ch05.boardpanel.v2.Rectangle;

public class Charts {
    @SuppressWarnings("unused")
    // tag::drawBarChart[]
    public static void drawBarChart(Graphics g,
        CategoryItemRendererState state,
        Rectangle graphArea,
        CategoryPlot plot,
        CategoryAxis domainAxis,
        ValueAxis rangeAxis,
        CategoryDataset dataset) {
        // ..
    }
    // end::drawBarChart[]

    // tag::drawBarChartDefault[]
    public static void drawBarChart(Graphics g, CategoryDataset dataset) {
        Charts.drawBarChart(g,
            CategoryItemRendererState.DEFAULT,
            new Rectangle(new Point(0, 0), 100, 100),
            CategoryPlot.DEFAULT,
            CategoryAxis.DEFAULT,
            ValueAxis.DEFAULT,
            dataset);
    }
    // end::drawBarChartDefault[]
}

class CategoryItemRendererState {
    public static final CategoryItemRendererState DEFAULT = null;
}

class CategoryPlot {
    public static final CategoryPlot DEFAULT = null;
}

class CategoryAxis {
    public static final CategoryAxis DEFAULT = null;
}

class ValueAxis {
    public static final ValueAxis DEFAULT = null;
}

class CategoryDataset {
    public static final CategoryDataset DEFAULT = null;
}
