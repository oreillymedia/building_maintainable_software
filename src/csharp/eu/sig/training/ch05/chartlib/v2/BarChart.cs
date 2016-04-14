using System.Drawing;
using System.Windows.Forms;
using Rectangle = eu.sig.training.ch05.boardpanel.v2.Rectangle;

namespace eu.sig.training.ch05.chartlib.v2
{
    // tag::BarChart[]
    public class BarChart
    {
        private CategoryItemRendererState state = CategoryItemRendererState.DEFAULT;
        private Rectangle graphArea = new Rectangle(new Point(0, 0), 100, 100);
        private CategoryPlot plot = CategoryPlot.DEFAULT;
        private CategoryAxis domainAxis = CategoryAxis.DEFAULT;
        private ValueAxis rangeAxis = ValueAxis.DEFAULT;
        private CategoryDataset dataset = CategoryDataset.DEFAULT;

        public BarChart Draw(Graphics g)
        {
            // ..
            return this;
        }

        public ValueAxis GetRangeAxis()
        {
            return rangeAxis;
        }

        public BarChart SetRangeAxis(ValueAxis rangeAxis)
        {
            this.rangeAxis = rangeAxis;
            return this;
        }

        // More getters and setters.

        // end::BarChart[]

        public CategoryItemRendererState GetState()
        {
            return state;
        }

        public BarChart setState(CategoryItemRendererState state)
        {
            this.state = state;
            return this;
        }

        public Rectangle getGraphArea()
        {
            return graphArea;
        }

        public BarChart setGraphArea(Rectangle graphArea)
        {
            this.graphArea = graphArea;
            return this;
        }

        public CategoryPlot getPlot()
        {
            return plot;
        }

        public BarChart setPlot(CategoryPlot plot)
        {
            this.plot = plot;
            return this;
        }

        public CategoryAxis getDomainAxis()
        {
            return domainAxis;
        }

        public BarChart setDomainAxis(CategoryAxis domainAxis)
        {
            this.domainAxis = domainAxis;
            return this;
        }

        public CategoryDataset getDataset()
        {
            return dataset;
        }

        public BarChart SetDataset(CategoryDataset dataset)
        {
            this.dataset = dataset;
            return this;
        }

    }

    public class CategoryItemRendererState
    {
        public const CategoryItemRendererState DEFAULT = null;
    }

    public class CategoryPlot
    {
        public const CategoryPlot DEFAULT = null;
    }

    public class CategoryAxis
    {
        public const CategoryAxis DEFAULT = null;
    }

    public class ValueAxis
    {
        public const ValueAxis DEFAULT = null;
    }

    public class CategoryDataset
    {
        public const CategoryDataset DEFAULT = null;
    }

    public class BarChartTest : Form
    {
        ValueAxis myValueAxis = null;
        CategoryDataset myDataset = null;
#pragma warning disable 219
        // tag::showMyBarChart[]
        private void ShowMyBarChart()
        {
            Graphics g = this.CreateGraphics();
            BarChart b = new BarChart()
                .SetRangeAxis(myValueAxis)
                .SetDataset(myDataset)
                .Draw(g);
        }
        // end::showMyBarChart[]
#pragma warning restore 219
    }
}
