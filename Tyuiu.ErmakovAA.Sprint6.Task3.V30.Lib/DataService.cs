using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ErmakovAA.Sprint6.Task3.V30.Lib

{
    public class DataService : ISprint6Task3V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                if (matrix[4, i] % 2 == 0)
                {
                    matrix[4, i] = 0;
                }
            }
            return matrix;

        }
    }
}
