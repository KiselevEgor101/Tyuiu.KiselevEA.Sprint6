using Tyuiu.KiselevEA.Sprint6.Task2.V2.Lib;
namespace Tyuiu.KiselevEA.Sprint6.Task2.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void ButtonClickResult_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStepData_KEA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStepData_KEA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                for (int i = 0; i<= len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-24-1 Киселев Егор Алексеевич", "Информация");
        }

        private void textBoxStopStepData_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartStepData_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
