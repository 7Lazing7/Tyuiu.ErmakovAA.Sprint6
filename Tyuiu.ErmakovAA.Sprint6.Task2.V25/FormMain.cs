using Tyuiu.ErmakovAA.Sprint6.Task2.V25.Lib;


namespace Tyuiu.ErmakovAA.Sprint6.Task2.V25
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
                int startStep = Convert.ToInt32(textBoxStartStep_SBI.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SBI.Text);

                int len = dataService.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);
                chartResult_SBI.Titles.Add("График функции: ((5x + 2,5)/(sin(x)-2))+ 2");

                chartResult_SBI.ChartAreas[0].AxisX.Title = "Ось X";
                chartResult_SBI.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    dataGridView_SBI.Rows.Add(Convert.ToString(startStep), valueArray[i]);
                    chartResult_SBI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Неверное значение" , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxSteps_SBI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_SBI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 2 | Вариант 25 | Ермаков А.А ", "INFO", MessageBoxButtons.OK);
        }


    }
}
