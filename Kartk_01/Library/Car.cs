namespace Library
{
    public class Car
    {
        public int NumberOfPassengers { get; private set; }

        public int MaxNumberOfPassengers { get; private set; }

        public Car(int maxNumberOfPassengers)
        {
            MaxNumberOfPassengers = maxNumberOfPassengers;
        }

        public int GetNumberOfPassengers()
        {
            return NumberOfPassengers;
        }

        public bool AddPassengers(int passengers)
        {
            if (passengers < 0)
            {
                return false;
            }

            checked
            {
                if (NumberOfPassengers + passengers > MaxNumberOfPassengers)
                {
                    return false;
                }

                NumberOfPassengers += passengers;
            }

            return true;
        }
    }
}
