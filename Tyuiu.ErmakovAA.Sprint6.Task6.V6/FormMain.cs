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
        private void buttonOpenFile_ErmakovAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ErmakovAA.ShowDialog();
            openFilePath = openFileDialogTask_ErmakovAA.FileName;
            textBoxInPutData_ErmakovAA.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_ErmakovAA.Text = groupBoxInPutData_ErmakovAA.Text + " " + openFileDialogTask_ErmakovAA.FileName;
            buttonDone_ErmakovAA.Enabled = true;

        }

        private void buttonDone_ErmakovAA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOutPutData_ErmakovAA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_ErmakovAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
