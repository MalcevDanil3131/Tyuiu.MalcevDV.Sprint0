using Tyuiu.MalcevDV.Sprit0.Task4.V0.Lib;
namespace Tyuiu.MalcevDV.Sprit0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(10, DataService.Substraction(15, 5));
        }
        [TestMethod]
        public void CheckedMultiplyValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(5, 2));
        }
        [TestMethod]
        public void CheckedDivideValid()
        {
            Assert.AreEqual(10, DataService.Divide(100, 10));
        }
    }
}