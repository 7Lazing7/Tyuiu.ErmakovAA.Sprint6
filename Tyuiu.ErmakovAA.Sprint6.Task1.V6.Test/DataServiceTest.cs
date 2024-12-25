using Tyuiu.ErmakovAA.Sprint6.Task1.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            double[] wait = new double[]
            {
                -14.74,-11.55,-7.59,-3.70,-0.73,2,3.86,6.64,10.27,14.08,17.27
            };
            CollectionAssert.AreEqual(wait, dataService.GetMassFunction(-5, 5));
        }
    }
}