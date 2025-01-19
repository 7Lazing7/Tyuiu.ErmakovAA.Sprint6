using Tyuiu.ErmakovAA.Sprint6.Task7.V21.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_SBI.Filter = "Çíà÷åíèÿ, ðàçäåë¸ííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
            saveFileDialog_SBI.Filter = "Çíà÷åíèÿ, ðàçäåë¸ííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
        }

        DataService dataService = new DataService();
        static int rows;
        static int columns;
        static string? openFilePath;

        private void buttonOpenFile_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Âûïîëíèòü";
        }

        private void buttonSaveFile_SBI_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SBI.ToolTipTitle = "Ñîõðàíèòü â ôàéë";
        }

        private void buttonAbout_SBI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_SBI_Click(object sender, EventArgs e)
        {
            int[,] values = dataService.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_SBI.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSaveFile_SBI.Enabled = true;
        }

        private void buttonOpenFile_SBI_Click(object sender, EventArgs e)
        {
            openFileDialog_SBI.ShowDialog();
            openFilePath = openFileDialog_SBI.FileName;

            if (openFilePath != null)
            {
                int[,] arrayValues = dataService.GetStartMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewInPut_SBI.ColumnCount = columns;
                dataGridViewInPut_SBI.RowCount = rows;
                dataGridViewOutPut_SBI.ColumnCount = columns;
                dataGridViewOutPut_SBI.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInPut_SBI.Columns[i].Width = 25;
                    dataGridViewOutPut_SBI.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInPut_SBI.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
                buttonDone_SBI.Enabled = true;
            }
        }

        private void buttonSaveFile_SBI_Click(object sender, EventArgs e)
        {
            saveFileDialog_SBI.FileName = "OutPutFileTask7.csv";
            saveFileDialog_SBI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SBI.ShowDialog();

            string path = saveFileDialog_SBI.FileName;

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
                        str += dataGridViewOutPut_SBI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut_SBI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}