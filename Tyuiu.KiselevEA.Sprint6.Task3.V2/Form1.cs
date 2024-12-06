
using Tyuiu.KiselevEA.Sprint6.Task3.V2.Lib;
namespace Tyuiu.KiselevEA.Sprint6.Task3.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -12, -4, -20, 5, -5 }, { 2, 15, 1, -20, 7 }, { 15, -15, 2, 11, 5 }, { -19, -9, 16, 0, 1 }, { 17, 16, 5, 12, -8 } };

        private void buttonDone_KEA_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetLength(0);
            int columns = mtrx.GetLength(1);

            textBoxOtvet_KEA.AppendText("Выполнено");


            dataGridViewMtrx_KEA.ColumnCount = columns;
            dataGridViewMtrx_KEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMtrx_KEA.Columns[i].Width = 30;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx_KEA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonInfo_KEA_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOtvet_KEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMtrx_KEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxCond_KEA_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewMtrx_KEA.ColumnCount = columns;
            dataGridViewMtrx_KEA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMtrx_KEA.Columns[i].Width = 30;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx_KEA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
