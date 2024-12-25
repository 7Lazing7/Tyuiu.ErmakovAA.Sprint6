using Tyuiu.ErmakovAA.Sprint6.Task0.V3.Lib;
namespace Tyuiu.ErmakovAA.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            try
            {
                textBoxResult_SBI.Text = Convert.ToString(dataService.Calculate(Convert.ToInt32(textBoxX_SBI.Text)));
            }
            catch
            {
                MessageBox.Show("Неверное значение", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_SBI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonQuestion_SBI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 1 | Вариант 6 | Ермаков А.А ", "INFO", MessageBoxButtons.OK);
        }
    }
}
