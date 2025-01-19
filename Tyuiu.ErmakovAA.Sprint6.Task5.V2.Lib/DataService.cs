using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ErmakovAA.Sprint6.Task5.V2.Lib
{
    public class DataService : ISprint6Task5V2
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> numsList = new List<double>();

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double num = Convert.ToDouble(line);
                    // Добавляем только те числа, которые не делятся на 5
                    if (num % 5 != 0)
                    {
                        numsList.Add(Math.Round(num, 3));
                    }
                }
            }

            return numsList.ToArray();
        }
    }
}