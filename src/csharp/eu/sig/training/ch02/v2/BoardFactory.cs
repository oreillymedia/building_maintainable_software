using System.Diagnostics;

namespace eu.sig.training.ch02.v2 {
	public class BoardFactory {
		// tag::createBoard[]
		public Board createBoard(Square[,] grid) {
			return new BoardCreator(grid).create();
		}
		// end::createBoard[]
	}

	// tag::BoardCreator[]
	internal class BoardCreator {
		private Square[,] grid;
		private Board board;
		private int width;
		private int height;

		internal BoardCreator (Square[,] grid) {
			Debug.Assert (grid != null);
			this.grid = grid;
			this.board = new Board (grid);
			this.width = board.Width;
			this.height = board.Height;
		}

		internal Board create() {
			for (int x = 0; x < width; x++) {
				for (int y = 0; y < height; y++) {
					Square square = grid [x, y];
					foreach (Direction dir in Direction.Values) {
						setLink (square, dir, x, y);
					}
				}
			}
			return this.board;
		}

		private void setLink(Square square, Direction dir, int x, int y) {
			int dirX = (width + x + dir.DeltaX) % width;
			int dirY = (height + y + dir.DeltaY) % height;
			Square neighbour = grid [dirX, dirY];
			square.link (neighbour, dir);
		}
	}

	// end::BoardCreator[]

	public class Board {
		public Board (Square[,] grid) {
		}

		public int Width { get; set; }

		public int Height { get; set; }
	}

	public class Square {
		public void link(Square neighbour, Direction dir) {
		}
	}

	public class Direction {
		public static Direction[] Values { get; set; }

		public int DeltaY { get; set; }

		public int DeltaX { get; set; }
	}
}
