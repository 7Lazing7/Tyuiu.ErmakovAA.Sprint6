using Tyuiu.ErmakovAA.Sprint6.Task0.V3.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 4.153;
            Assert.AreEqual(res,wait);
        }
    }
}