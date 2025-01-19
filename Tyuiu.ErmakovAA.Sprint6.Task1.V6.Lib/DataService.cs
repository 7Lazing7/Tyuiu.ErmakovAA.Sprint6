using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ErmakovAA.Sprint6.Task1.V6.Lib
{
    public class DataService : ISprint6Task1V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;

            for (int i = startValue; i <= stopValue; i++)
            {

                values[index] = Math.Round((Math.Sin(i) - (2 * i)) / ((3 * i) - 1) + Math.Sin(i) - (3 * i) + 2, 2);
                index++;
            }
            return values;
        }
    }
}