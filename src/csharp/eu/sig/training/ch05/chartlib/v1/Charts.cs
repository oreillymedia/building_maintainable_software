using System.Drawing;
using Rectangle = eu.sig.training.ch05.boardpanel.v2.Rectangle;

namespace eu.sig.training.ch05.chartlib.v1
{
    public class Charts
    {
        // tag::drawBarChart[]
        public static void DrawBarChart(Graphics g,
            CategoryItemRendererState state,
            Rectangle graphArea,
            CategoryPlot plot,
            CategoryAxis domainAxis,
            ValueAxis rangeAxis,
            CategoryDataset dataset)
        {
            // ..
        }
        // end::drawBarChart[]

        // tag::drawBarChartDefault[]
        public static void DrawBarChart(Graphics g, CategoryDataset dataset)
        {
            Charts.DrawBarChart(g,
                CategoryItemRendererState.DEFAULT,
                new Rectangle(new Point(0, 0), 100, 100),
                CategoryPlot.DEFAULT,
                CategoryAxis.DEFAULT,
                ValueAxis.DEFAULT,
                dataset);
        }
        // end::drawBarChartDefault[]
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
}
