using CarFactoryLibrary;

namespace CarFactoryLibaray_Lap1_test
{
    public class CarFactory_Lap_Tests
    {
        [Fact]
        public void NewCar_CarTypeBMW_BMW()
        {
            // 1) Arrange
            // 2) Act
            Car? car = CarFactory.NewCar(CarTypes.BMW);
            // 3) Assert
            Assert.NotNull(car);
            Assert.IsType<BMW>(car);

        }


        [Fact]
        public void NewCar_CarTypeHonda_Exception()
        {
            // A1
            // A3
            Assert.Throws<NotImplementedException>(() =>
            {
                // A2
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }

    }
}
