using System;

namespace eu.sig.training.ch02 {
	
	public class LevelHelper {
		private bool inProgress;

		// tag::firstStepStart[]
		public void start() {
			if (inProgress) {
				return;
			}
			inProgress = true;
		}
		// end::firstStepStart[]
	}

	public class ExtractMethod {
		private bool inProgress;

		// tag::extractMethodStart[]
		public void start() {
			if (inProgress) {
				return;
			}
			inProgress = true;
			updateObservers();
		}
		// end::extractMethodStart[]

		// tag::updateObservers[]
		public void updateObservers() {
			updateObserversPlayerDied();
			updateObserversPelletsEaten();
		}
		// end::updateObservers[]

		private void updateObserversPlayerDied() {}

		private void updateObserversPelletsEaten() {}
	
	}

}