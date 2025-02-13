using Tyuiu.ErmakovAA.Sprint6.Task3.V30.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task3.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] {
            {-9, -4, 17, -1, 20},
            {-19, 18, -4, 2, 14},
            {-12, 16, -2, 7, 18},
            {-16, 15, 4, -12, -13},
            {-15, -4, -16, 1, -14}
        };
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 3 | Вариант 30 | Ермаков А.А ", "INFO", MessageBoxButtons.OK);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

            mtrx = ds.Calculate(mtrx);

            UpdateDataGridView(dataGridViewMatrix2_ErmakovAA);
        }

        private void UpdateDataGridView(DataGridView dataGridView)
        {
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            dataGridView.ColumnCount = columns;
            dataGridView.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_ErmakovAA.ColumnCount = columns;
            dataGridViewMatrix_ErmakovAA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_ErmakovAA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewMatrix_ErmakovAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }

}
