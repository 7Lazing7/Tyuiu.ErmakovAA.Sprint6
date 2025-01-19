using Tyuiu.ErmakovAA.Sprint6.Task6.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_TVD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_TVD.ShowDialog();
            openFilePath = openFileDialogTask_TVD.FileName;
            textBoxInPutData_TVD.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_TVD.Text = groupBoxInPutData_TVD.Text + " " + openFileDialogTask_TVD.FileName;
            buttonDone_TVD.Enabled = true;

        }

        private void buttonDone_TVD_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOutPutData_TVD.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_TVD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}

