using Tyuiu.ErmakovAA.Sprint6.Task1.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task1.V6
{

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_ErmakovAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ErmakovAA.Text);
                string strLine;
                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);

                textBoxResult_ErmakovAA.Text = "";
                textBoxResult_ErmakovAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_ErmakovAA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_ErmakovAA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_ErmakovAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_ErmakovAA.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверное значение" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBoxSteps_ErmakovAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_ErmakovAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 1 | Вариант 6 | Ермаков А.А ", "INFO", MessageBoxButtons.OK);
        }
    }
}


