using Library;

namespace Library.Tests
{
    public class CarTests
    {
        [Theory]
        [InlineData(0, 5)]
        [InlineData(2, 2)]
        [InlineData(2, 5)]
        public void Car_AddPassangers_ReturnsTrue(int passangers, int maxPassangers)
        {
            // Arrange
            Car car = new(maxPassangers);

            // Act
            bool result = car.AddPassengers(passangers);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Car_AddPassangersManyTimes_ReturnsTrue()
        {
            // Arrange
            int maxPassangers = 10;
            int passangersFirst = 3;
            int passangersSecond = 4;
            Car car = new(maxPassangers);

            // Act
            car.AddPassengers(passangersFirst);
            bool result = car.AddPassengers(passangersSecond);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Car_AddExceedPassangers_ReturnsFalse()
        {
            // Arrange
            int maxPassangers = 5;
            int passangers = 6;
            Car car = new(maxPassangers);

            // Act
            bool result = car.AddPassengers(passangers);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void Car_AddExceedPassangersManyTimes_ReturnsFalse()
        {
            // Arrange
            int maxPassangers = 5;
            int passangersFirst = 3;
            int passangersSecond = 4;
            Car car = new(maxPassangers);

            // Act
            car.AddPassengers(passangersFirst);
            bool result = car.AddPassengers(passangersSecond);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Car_AddPassangers_HasCorrectFieldValue()
        {
            // Arrange
            int maxPassangers = 10;
            Car car = new(maxPassangers);
            int passangers = 3;
            int expectedPassangers = 3;

            // Act
            car.AddPassengers(passangers);

            // Assert
            Assert.Equal(expectedPassangers, car.NumberOfPassengers);
        }

        [Fact]
        public void Car_AddExceedPassangers_HasCorrectFieldValue()
        {
            // Arrange
            int maxPassangers = 10;
            Car car = new(maxPassangers);
            int passangers = 15;
            int expectedPassangers = 0;

            // Act
            car.AddPassengers(passangers);

            // Assert
            Assert.Equal(expectedPassangers, car.NumberOfPassengers);
        }

        [Fact]
        public void Car_GetPassangers_ReturnsCorrectValue()
        {
            // Arrange
            int maxPassangers = 20;
            int passangers = 15;
            int expectedPassangers = 15;
            Car car = new(maxPassangers);

            // Act
            car.AddPassengers(passangers);
            int result = car.GetNumberOfPassengers();

            // Assert
            Assert.Equal(expectedPassangers, car.NumberOfPassengers);
        }

        [Fact]
        public void Car_AddNegativePassangers_DoesntAdd()
        {
            // Arrange
            int maxPassangers = 10;
            Car car = new(maxPassangers);
            int passangers = -10;
            int expectedPassangers = 0;

            // Act
            car.AddPassengers(passangers);

            // Assert
            Assert.Equal(expectedPassangers, car.NumberOfPassengers);
        }
    }
}
