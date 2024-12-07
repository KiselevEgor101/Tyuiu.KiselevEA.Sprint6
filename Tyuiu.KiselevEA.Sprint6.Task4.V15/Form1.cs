using Tyuiu.KiselevEA.Sprint6.Task4.V15.Lib;
namespace Tyuiu.KiselevEA.Sprint6.Task4.V15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void groupBoxData_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSave_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
                string path = Path.Combine(paths);
                File.WriteAllText(path, textBox1.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " Сохранён успешно\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStepData_KEA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStepData_KEA.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);
                chart_KEA.ChartAreas[0].AxisX.Title = "Îñü X";
                chart_KEA.ChartAreas[0].AxisY.Title = "Îñü Y";
                textBox1.Text = "";
                for (int i = 0; i < valueArray.Length; i++)
                {
                    chart_KEA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBox1.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка  " + ex.Message, "Неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-24-1 Киселев Егор Алексеевич", "Информация");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartStepData_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopStepData_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart_KEA_Click(object sender, EventArgs e)
        {

        }

        

    }
}
