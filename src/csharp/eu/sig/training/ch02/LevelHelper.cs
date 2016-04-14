namespace eu.sig.training.ch02
{

    public class LevelHelper
    {
        private bool inProgress;

        // tag::firstStepStart[]
        public void Start()
        {
            if (inProgress)
            {
                return;
            }
            inProgress = true;
        }
        // end::firstStepStart[]
    }

    public class ExtractMethod
    {
        private bool inProgress;

        // tag::extractMethodStart[]
        public void Start()
        {
            if (inProgress)
            {
                return;
            }
            inProgress = true;
            UpdateObservers();
        }
        // end::extractMethodStart[]

        // tag::updateObservers[]
        public void UpdateObservers()
        {
            UpdateObserversPlayerDied();
            UpdateObserversPelletsEaten();
        }
        // end::updateObservers[]

        private void UpdateObserversPlayerDied() { }

        private void UpdateObserversPelletsEaten() { }

    }

}
