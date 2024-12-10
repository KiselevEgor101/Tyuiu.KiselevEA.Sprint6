using System.Windows.Forms;
using Tyuiu.KiselevEA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.KiselevEA.Sprint6.Task7.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        static int rows;
        static int cols;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return matrix;
        }

        private void buttonOpen_KEA_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            int[,] matrix = new int[rows, cols];

            matrix = LoadFromFileData(openFilePath);

            dataGridViewIN_KEA.ColumnCount = cols;
            dataGridViewIN_KEA.RowCount = rows;
            dataGridViewOUT_KEA.ColumnCount = cols;
            dataGridViewOUT_KEA.RowCount = rows;

            for (int h = 0; h < cols; h++)
            {
                dataGridViewIN_KEA.Columns[h].Width = 35;
                dataGridViewOUT_KEA.Columns[h].Width = 35;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewIN_KEA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            matrix = ds.GetMatrix(openFilePath);
            buttonDone_KEA.Enabled = true;

        }

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[rows, cols];
            matrix = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOUT_KEA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
            buttonSave_KEA.Enabled = true;
        }

        private void buttonSave_KEA_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOUT_KEA.RowCount;
            int columns = dataGridViewOUT_KEA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOUT_KEA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOUT_KEA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void dataGridViewIN_KEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOUT_KEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxIN_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAbout_KEA_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
