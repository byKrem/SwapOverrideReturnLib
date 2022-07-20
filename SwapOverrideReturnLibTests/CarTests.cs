using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwapOverrideReturnLib.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void EqualsTest()
        {
            Car car1 = new Car { Model="BMW", Color = "Red", Description = "E34" };
            Car car2 = new Car { Model="BMW", Color = "Red", Description = "E34" };
            Assert.IsTrue(car1.Equals(car2));
            car2 = new Car { Model = "BMW", Color = "Blue", Description = "E34" };
            Assert.IsFalse(car1.Equals(car2));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Car car1 = new Car { Model = "BMW", Color = "Red", Description = "E34" };
            Car car2 = new Car { Model = "BMW", Color = "Red", Description = "E34" };
            Assert.IsTrue(car1.GetHashCode() == car2.GetHashCode());
            car2 = new Car { Model = "BMW", Color = "Blue", Description = "E34" };
            Assert.IsFalse(car1.GetHashCode() == car2.GetHashCode());
        }
    }
}