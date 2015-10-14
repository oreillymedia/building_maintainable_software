package eu.sig.training.ch05.boardpanel.v2;

import java.awt.Graphics;
import java.awt.Point;
import java.util.List;

public class BoardPanel {
    @SuppressWarnings("unused")
    // tag::render[]
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
    private void render(Square square, Graphics g, Rectangle r) {
        Point position = r.getPosition();
        square.getSprite().draw(g, position.x, position.y, r.getWidth(),
            r.getHeight());
        for (Unit unit : square.getOccupants()) {
            unit.getSprite().draw(g, position.x, position.y, r.getWidth(),
                r.getHeight());
        }
    }
    // end::render[]

    private class Sprite {
        @SuppressWarnings("unused")
        public void draw(Graphics g, int x, int y, int w, int h) {

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
