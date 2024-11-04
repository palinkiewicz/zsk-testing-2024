namespace Kartkowka
{
    public class Car
    {
        public int NumberOfPassengers { get; private set; }

        public int MaxNumberOfPassengers { get; init; }

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

            if (NumberOfPassengers + passengers > MaxNumberOfPassengers)
            {
                return false;
            }

            NumberOfPassengers += passengers;

            return true;
        }
    }
}
