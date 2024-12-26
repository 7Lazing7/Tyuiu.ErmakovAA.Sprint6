using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ErmakovAA.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                values[index] = Math.Round((5 * i + 2.5) / (Math.Sin(i) -2) + 2,2);
                index++;
            }
            return values;
        }

    }
}
