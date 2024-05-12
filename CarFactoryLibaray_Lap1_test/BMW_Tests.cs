using CarFactoryLibrary;

namespace CarFactoryLibaray_Lap1_test
{
    public class BMW_Tests
    {
        [Fact]
        public void IsStopped_VelocityEqualZero_true()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.velocity = 0;
            //A 2
            bool carStoped = bmw.IsStopped();
            //A 3
            Assert.True(carStoped);
        }
        [Fact]
        public void GetMyCar_callFunc_SameCar()
        {
            //A 1
            BMW bmw = new BMW();
            //A 2
            Car mycar = bmw.GetMyCar();
            //A 3
            Assert.Same(bmw, mycar);
        }
        [Fact]
        public void IncreaseVelocity_velocity1000AddedTo500_Equals1500()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.velocity = 500;
            double PlusVelocity = 1000;
            //A 2
            bmw.IncreaseVelocity(PlusVelocity);
            //A 3
            Assert.Equal(1500, bmw.velocity);
        }
       

        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            //A 2
            string GettedResult = bmw.GetDirection();
            //A 3
            Assert.Equal(DrivingMode.Forward.ToString(), GettedResult);
            Assert.StartsWith("F", GettedResult);
        }

        [Fact]
        public void TimeToCoverDistance_distance100_Velocity50_2()
        {
            //A 1
            BMW bmw = new BMW();
            bmw.velocity = 50;
            double distance = 100;
            //A 2
            double result = bmw.TimeToCoverDistance(distance);
            //A 3
            Assert.Equal(2, result);
        }

        


    }
}
