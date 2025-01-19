using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ErmakovAA.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21
    {
        public int[,] GetMatrix(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);

            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length; 

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line[j]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 7; j <= 7; j++)
                {
                    if (arrayValues[i, j] != 5) arrayValues[i, j] = -1;
                }
            }
            return arrayValues;
        }


        public int[,] GetStartMatrix(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);

            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return arrayValues;
        }

    }
}

