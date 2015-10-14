package eu.sig.training.ch05.boardpanel.v2;

import java.awt.Point;

// tag::Rectangle[]
public class Rectangle {
    private final Point position;
    private final int width;
    private final int height;

    public Rectangle(Point position, int width, int height) {
        this.position = position;
        this.width = width;
        this.height = height;
    }

    public Point getPosition() {
        return position;
    }

    public int getWidth() {
        return width;
    }

    public int getHeight() {
        return height;
    }
}
// end::Rectangle[]