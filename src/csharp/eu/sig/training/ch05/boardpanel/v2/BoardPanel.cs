using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch05.boardpanel.v2
{

    public class BoardPanel
    {
        // tag::render[]
        /// <summary>
        /// Renders a single square on the given graphics context on the specified
        /// rectangle.
        ///
        /// <param name="square">The square to render.</param>
        /// <param name="g">The graphics context to draw on.</param>
        /// <param name="r">The position and dimension for rendering the square.</param>
        private void Render(Square square, Graphics g, Rectangle r)
        {
            Point position = r.Position;
            square.Sprite.Draw(g, position.X, position.Y, r.Width, r.Height);
            foreach (Unit unit in square.Occupants)
            {
                unit.Sprite.Draw(g, position.X, position.Y, r.Width, r.Height);
            }
        }
        // end::render[]

        private class Sprite
        {
            public void Draw(Graphics g, int x, int y, int w, int h)
            {

            }
        }

        private class Unit
        {
            public Sprite Sprite { get; set; }
        }

        private class Square : Unit
        {

            public IList<Unit> Occupants { get; set; }

        }
    }
}
