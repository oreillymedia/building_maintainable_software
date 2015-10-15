using System.Drawing;
using System.Collections.Generic;

namespace eu.sig.training.ch03 {

	public class Flag {
		private readonly IList<Color> colors;

		public Flag (params Color[] colors) {
			this.colors = new List<Color>(colors);
		}

		public IList<Color> getColors() {
			return colors;
		}
	}

}