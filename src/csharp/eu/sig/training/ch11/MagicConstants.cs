namespace eu.sig.training.ch11
{
    public class MagicConstants
    {

        public class Customer
        {

            public Customer(int age)
            {
                this.Age = age;
            }

            public int Age { get; set; }
        }

        public class UseMagicConstants
        {

            // tag::calculateFareMagicConstants[]
            float CalculateFare(Customer c, long distance)
            {
                float travelledDistanceFare = distance * 0.10f;
                if (c.Age < 12)
                {
                    travelledDistanceFare *= 0.25f;
                }
                else
                    if (c.Age >= 65)
                {
                    travelledDistanceFare *= 0.5f;
                }
                return 3.00f + travelledDistanceFare;
            }
            // end::calculateFareMagicConstants[]

        }

        public class DoNotUseMagicConstants
        {
            // tag::calculateFareDoNotUseMagicConstants[]
            private static readonly float BASE_RATE = 3.00f;
            private static readonly float FARE_PER_KM = 0.10f;
            private static readonly float DISCOUNT_RATE_CHILDREN = 0.25f;
            private static readonly float DISCOUNT_RATE_ELDERLY = 0.5f;
            private static readonly int MAXIMUM_AGE_CHILDREN = 12;
            private static readonly int MINIMUM_AGE_ELDERLY = 65;

            float CalculateFare(Customer c, long distance)
            {
                float travelledDistanceFare = distance * FARE_PER_KM;
                if (c.Age < MAXIMUM_AGE_CHILDREN)
                {
                    travelledDistanceFare *= DISCOUNT_RATE_CHILDREN;
                }
                else
                    if (c.Age >= MINIMUM_AGE_ELDERLY)
                {
                    travelledDistanceFare *= DISCOUNT_RATE_ELDERLY;
                }
                return BASE_RATE + travelledDistanceFare;
            }
            // end::calculateFareDoNotUseMagicConstants[]
        }
    }
}
