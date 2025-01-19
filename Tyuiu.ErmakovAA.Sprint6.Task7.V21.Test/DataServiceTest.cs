using Tyuiu.ErmakovAA.Sprint6.Task7.V21.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFile()
        {
            Assert.AreEqual(true, File.Exists(@"C:\Users\User\source\repos\Tyuiu.SaigafarovBI.Sprint6\gg.csv"));
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.SaigafarovBI.Sprint6\gg.csv";
            int[,] wait = new int[2, 9]
            {
                { 9,3,1,25,125,12,5,-1,5},
                { 124,2,12,25,6,1,1,-1,1}
            };
            CollectionAssert.AreEqual(dataService.GetMatrix(path), wait);
        }
    }
}