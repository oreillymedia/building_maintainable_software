using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03.withmapandtypes {

	public class FrenchFlag : Flag {
		public IList<Color> getColors() {
            return new List<Color>{ Color.Blue, Color.White, Color.Red };
		}
	}

}