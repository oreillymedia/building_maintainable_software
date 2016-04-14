using System.Drawing;

namespace eu.sig.training.ch05.boardpanel.v2
{
    // tag::Rectangle[]
    public class Rectangle
    {
        public Point Position { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Rectangle(Point position, int width, int height)
        {
            this.Position = position;
            this.Width = width;
            this.Height = height;
        }

    }
    // end::Rectangle[]
}