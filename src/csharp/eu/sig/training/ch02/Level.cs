using System.Collections.Generic;

namespace eu.sig.training.ch02 {
	
    public class Level {
        private bool inProgress;
        private readonly IList<LevelObserver> observers;

        Level(IList<LevelObserver> observers) {
            this.observers = observers;
        }

        // tag::start[]
        public void start() {
            if (inProgress) {
                return;
            }
            inProgress = true;
            // Update observers if player died:
            if (!isAnyPlayerAlive()) {
                foreach (LevelObserver o in observers) {
                    o.levelLost();
                }
            }
            // Update observers if all pellets eaten:
            if (remainingPellets() == 0) {
                foreach (LevelObserver o in observers) {
                    o.levelWon();
                }
            }
        }
        // end::start[]

        // tag::updateObservers[]
        private void updateObservers() {
            // Update observers if player died:
            if (!isAnyPlayerAlive()) {
                foreach (LevelObserver o in observers) {
                    o.levelLost();
                }
            }
            // Update observers if all pellets eaten:
            if (remainingPellets() == 0) {
                foreach (LevelObserver o in observers) {
                    o.levelWon();
                }
            }
        }
        // end::updateObservers[]

        // tag::updateObserversPlayerDied[]
        private void updateObserversPlayerDied() {
            if (!isAnyPlayerAlive()) {
                foreach (LevelObserver o in observers) {
                    o.levelLost();
                }
            }
        }

        // end::updateObserversPlayerDied[]

        // tag::updateObserversPelletsEaten[]
        private void updateObserversPelletsEaten() {
            if (remainingPellets() == 0) {
                foreach (LevelObserver o in observers) {
                    o.levelWon();
                }
            }
        }
        // end::updateObserversPelletsEaten[]

        private int remainingPellets() {
            return 0;
        }

        private bool isAnyPlayerAlive() {
            return false;
        }
    }

    class LevelObserver {
        public void levelLost() {}
        public void levelWon() {}
    }

}