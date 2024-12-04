using Tyuiu.KiselevEA.Sprint6.Task1.V5.Lib;
namespace Tyuiu.KiselevEA.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void textBoxParamStop_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxParamStart_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxParamStart_KEA.Text);
                int stopStep = Convert.ToInt32(textBoxParamStop_KEA.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_KEA.Text = "";
                textBoxResult_KEA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KEA.AppendText("+    X     |   f(x)   +" + Environment.NewLine);
                textBoxResult_KEA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}         |", startStep, valueArray[i]);
                    textBoxResult_KEA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KEA.AppendText("+----------+----------+" + Environment.NewLine);
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-24-1 Киселев Егор Алексеевич", "Информация");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2Result_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxConditional_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_KEA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
