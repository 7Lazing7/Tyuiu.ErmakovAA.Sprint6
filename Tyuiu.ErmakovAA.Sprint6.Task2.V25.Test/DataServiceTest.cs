using Tyuiu.ErmakovAA.Sprint6.Task2.V25.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = { 23.61, 16.08, 7.84, 4.58, 2.88, 0.75, -4.47, -9.46, -7.41, -6.16, -7.29 };
            var res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
