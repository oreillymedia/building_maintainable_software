package eu.sig.training.ch02;

public class LevelHelper {
    private boolean inProgress;

    // tag::firstStepStart[]
    public void start() {
        if (inProgress) {
            return;
        }
        inProgress = true;
    }
    // end::firstStepStart[]
}

class ExtractMethod {
    private boolean inProgress;

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
    private void updateObservers() {
        updateObserversPlayerDied();
        updateObserversPelletsEaten();
    }
    // end::updateObservers[]

    private void updateObserversPlayerDied() {}

    private void updateObserversPelletsEaten() {}
}
