package eu.sig.training.ch02;

public class BoardFactory {
    // tag::createBoard[]
    public Board createBoard(Square[][] grid) {
        assert grid != null;

        Board board = new Board(grid);

        int width = board.getWidth();
        int height = board.getHeight();
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                Square square = grid[x][y];
                for (Direction dir : Direction.values()) {
                    int dirX = (width + x + dir.getDeltaX()) % width;
                    int dirY = (height + y + dir.getDeltaY()) % height;
                    Square neighbour = grid[dirX][dirY];
                    square.link(neighbour, dir);
                }
            }
        }

        return board;
    }
    // end::createBoard[]
}

class Board {
    @SuppressWarnings("unused")
    public Board(Square[][] grid) {}

    public int getWidth() {
        return 0;
    }

    public int getHeight() {
        return 0;
    }
}

class Square {
    @SuppressWarnings("unused")
    public void link(Square neighbour, Direction dir) {}
}

class Direction {

    public static Direction[] values() {
        return null;
    }

    public int getDeltaY() {
        return 0;
    }

    public int getDeltaX() {
        return 0;
    }
}
