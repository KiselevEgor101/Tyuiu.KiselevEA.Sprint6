using Tyuiu.KiselevEA.Sprint6.Task6.V25.Lib;
namespace Tyuiu.KiselevEA.Sprint6.Task6.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void buttonFile_KEA_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxINdata_KEA.Text = File.ReadAllText(openFilePath);
            groupBox1.Text = groupBox1.Text + " " + openFileDialog1.FileName;
            buttonDone_KEA.Enabled = true;

        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxDataOut_KEA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void textBoxINdata_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDataOut_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {
            FormInfo formAbout = new FormInfo();
            formAbout.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
