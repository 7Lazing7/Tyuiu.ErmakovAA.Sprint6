using Tyuiu.ErmakovAA.Sprint6.Task7.V21.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_ErmakovAA.Filter = "Çíà÷åíèÿ, ðàçäåë¸ííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
            saveFileDialog_ErmakovAA.Filter = "Çíà÷åíèÿ, ðàçäåë¸ííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
        }

        DataService dataService = new DataService();
        static int rows;
        static int columns;
        static string? openFilePath;

        private void buttonOpenFile_ErmakovAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ErmakovAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_ErmakovAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ErmakovAA.ToolTipTitle = "Âûïîëíèòü";
        }

        private void buttonSaveFile_ErmakovAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_ErmakovAA.ToolTipTitle = "Ñîõðàíèòü â ôàéë";
        }

        private void buttonAbout_ErmakovAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_ErmakovAA_Click(object sender, EventArgs e)
        {
            int[,] values = dataService.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_ErmakovAA.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSaveFile_ErmakovAA.Enabled = true;
        }

        private void buttonOpenFile_ErmakovAA_Click(object sender, EventArgs e)
        {
            openFileDialog_ErmakovAA.ShowDialog();
            openFilePath = openFileDialog_ErmakovAA.FileName;

            if (openFilePath != null)
            {
                int[,] arrayValues = dataService.GetStartMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewInPut_ErmakovAA.ColumnCount = columns;
                dataGridViewInPut_ErmakovAA.RowCount = rows;
                dataGridViewOutPut_ErmakovAA.ColumnCount = columns;
                dataGridViewOutPut_ErmakovAA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInPut_ErmakovAA.Columns[i].Width = 25;
                    dataGridViewOutPut_ErmakovAA.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInPut_ErmakovAA.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
                buttonDone_ErmakovAA.Enabled = true;
            }
        }

        private void buttonSaveFile_ErmakovAA_Click(object sender, EventArgs e)
        {
            saveFileDialog_ErmakovAA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_ErmakovAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_ErmakovAA.ShowDialog();

            string path = saveFileDialog_ErmakovAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut_ErmakovAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut_ErmakovAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}