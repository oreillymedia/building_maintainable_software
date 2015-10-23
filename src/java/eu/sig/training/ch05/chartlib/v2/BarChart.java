package eu.sig.training.ch05.chartlib.v2;

import java.awt.Graphics;
import java.awt.Point;

import eu.sig.training.ch05.boardpanel.v2.Rectangle;

@SuppressWarnings("unused")
// tag::BarChart[]
public class BarChart {
    private CategoryItemRendererState state = CategoryItemRendererState.DEFAULT;
    private Rectangle graphArea = new Rectangle(new Point(0, 0), 100, 100);
    private CategoryPlot plot = CategoryPlot.DEFAULT;
    private CategoryAxis domainAxis = CategoryAxis.DEFAULT;
    private ValueAxis rangeAxis = ValueAxis.DEFAULT;
    private CategoryDataset dataset = CategoryDataset.DEFAULT;

    public BarChart draw(Graphics g) {
        // ..
        return this;
    }

    public ValueAxis getRangeAxis() {
        return rangeAxis;
    }

    public BarChart setRangeAxis(ValueAxis rangeAxis) {
        this.rangeAxis = rangeAxis;
        return this;
    }

    // More getters and setters.

    // end::BarChart[]

    public CategoryItemRendererState getState() {
        return state;
    }

    public BarChart setState(CategoryItemRendererState state) {
        this.state = state;
        return this;
    }

    public Rectangle getGraphArea() {
        return graphArea;
    }

    public BarChart setGraphArea(Rectangle graphArea) {
        this.graphArea = graphArea;
        return this;
    }

    public CategoryPlot getPlot() {
        return plot;
    }

    public BarChart setPlot(CategoryPlot plot) {
        this.plot = plot;
        return this;
    }

    public CategoryAxis getDomainAxis() {
        return domainAxis;
    }

    public BarChart setDomainAxis(CategoryAxis domainAxis) {
        this.domainAxis = domainAxis;
        return this;
    }

    public CategoryDataset getDataset() {
        return dataset;
    }

    public BarChart setDataset(CategoryDataset dataset) {
        this.dataset = dataset;
        return this;
    }

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

@SuppressWarnings("serial")
class BarChartTest extends java.awt.Frame {
    ValueAxis myValueAxis = null;
    CategoryDataset myDataset = null;
    @SuppressWarnings("unused")
    // tag::showMyBarChart[]
    private void showMyBarChart() {
        Graphics g = this.getGraphics();
        BarChart b = new BarChart()
            .setRangeAxis(myValueAxis)
            .setDataset(myDataset)
            .draw(g);
    }
    // end::showMyBarChart[]
}
