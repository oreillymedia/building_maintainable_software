package eu.sig.training.ch11;

public class MagicConstants {

    public class Customer {
        private final int age;

        public Customer(int age) {
            this.age = age;
        }

        public int getAge() {
            return age;
        }
    }

    public class UseMagicConstants {

        // tag::calculateFareMagicConstants[]
        float calculateFare(Customer c, long distance) {
            float travelledDistanceFare = distance * 0.10f;
            if (c.getAge() < 12) {
                travelledDistanceFare *= 0.25f;
            } else
                if (c.getAge() >= 65) {
                travelledDistanceFare *= 0.5f;
            }
            return 3.00f + travelledDistanceFare;
        }
        // end::calculateFareMagicConstants[]

    }

    public class DoNotUseMagicConstants {
        // tag::calculateFareDoNotUseMagicConstants[]
        private static final float BASE_RATE = 3.00f;
        private static final float FARE_PER_KM = 0.10f;
        private static final float DISCOUNT_RATE_CHILDREN = 0.25f;
        private static final float DISCOUNT_RATE_ELDERLY = 0.5f;
        private static final int MAXIMUM_AGE_CHILDREN = 12;
        private static final int MINIMUM_AGE_ELDERLY = 65;

        float calculateFare(Customer c, long distance) {
            float travelledDistanceFare = distance * FARE_PER_KM;
            if (c.getAge() < MAXIMUM_AGE_CHILDREN) {
                travelledDistanceFare *= DISCOUNT_RATE_CHILDREN;
            } else
                if (c.getAge() >= MINIMUM_AGE_ELDERLY) {
                travelledDistanceFare *= DISCOUNT_RATE_ELDERLY;
            }
            return BASE_RATE + travelledDistanceFare;
        }
        // end::calculateFareDoNotUseMagicConstants[]

    }

}
