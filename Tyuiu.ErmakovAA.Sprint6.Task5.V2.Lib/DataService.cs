using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ErmakovAA.Sprint6.Task5.V2.Lib
{
    public class DataService : ISprint6Task5V2
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> negativeNums = new List<double>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double num = Convert.ToDouble(line);
                    // Проверяем только отрицательные числа
                    if (num < 0)
                    {
                        negativeNums.Add(Math.Round(num, 3));
                    }
                }
            }

            return negativeNums.ToArray();
        }
    }
}