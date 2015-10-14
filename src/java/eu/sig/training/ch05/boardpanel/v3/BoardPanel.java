package eu.sig.training.ch05.boardpanel.v3;

import java.awt.Graphics;
import java.awt.Point;
import java.util.List;

import eu.sig.training.ch05.boardpanel.v2.Rectangle;

public class BoardPanel {
    @SuppressWarnings("unused")
    /**
     * Renders a single square on the given graphics context on the specified
     * rectangle.
     * 
     * @param square
     *            The square to render.
     * @param g
     *            The graphics context to draw on.
     * @param r
     *            The position and dimension for rendering the square.
     */
    // tag::render[]
    private void render(Square square, Graphics g, Rectangle r) {
        Point position = r.getPosition();
        square.getSprite().draw(g, r);
        for (Unit unit : square.getOccupants()) {
            unit.getSprite().draw(g, r);
        }
    }
    // end::render[]

    private class Sprite {
        @SuppressWarnings("unused")
        public void draw(Graphics g, Rectangle r) {

        }
    }

    private class Unit {
        public Sprite getSprite() {
            return null;
        }
    }

    private class Square extends Unit {

        public List<Unit> getOccupants() {
            return null;
        }

    }
}
