namespace Tyuiu.KiselevEA.Sprint6.Task3.V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCond_KEA = new GroupBox();
            textBox1 = new TextBox();
            groupBoxRes_KEA = new GroupBox();
            buttonInfo_KEA = new Button();
            buttonDone_KEA = new Button();
            textBoxOtvet_KEA = new TextBox();
            textBoxRes_KEA = new TextBox();
            dataGridViewMtrx_KEA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBoxCond_KEA.SuspendLayout();
            groupBoxRes_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_KEA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCond_KEA
            // 
            groupBoxCond_KEA.Controls.Add(textBox1);
            groupBoxCond_KEA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxCond_KEA.Location = new Point(10, 11);
            groupBoxCond_KEA.Name = "groupBoxCond_KEA";
            groupBoxCond_KEA.Size = new Size(242, 427);
            groupBoxCond_KEA.TabIndex = 0;
            groupBoxCond_KEA.TabStop = false;
            groupBoxCond_KEA.Text = "Условие";
            groupBoxCond_KEA.Enter += groupBoxCond_KEA_Enter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(2, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(234, 306);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица:\r\n-12  -4 -20   5  -5\r\n   2  15   1 -20   7\r\n  15 -15   2  11   5\r\n -19  -9  16   0   1\r\n  17  16   5  12  -8\r\nЗаменить четные значения в первой строке на 0.";
            // 
            // groupBoxRes_KEA
            // 
            groupBoxRes_KEA.Controls.Add(buttonInfo_KEA);
            groupBoxRes_KEA.Controls.Add(buttonDone_KEA);
            groupBoxRes_KEA.Controls.Add(textBoxOtvet_KEA);
            groupBoxRes_KEA.Controls.Add(textBoxRes_KEA);
            groupBoxRes_KEA.Controls.Add(dataGridViewMtrx_KEA);
            groupBoxRes_KEA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxRes_KEA.Location = new Point(258, 10);
            groupBoxRes_KEA.Name = "groupBoxRes_KEA";
            groupBoxRes_KEA.Size = new Size(530, 425);
            groupBoxRes_KEA.TabIndex = 1;
            groupBoxRes_KEA.TabStop = false;
            groupBoxRes_KEA.Text = "Результат";
            // 
            // buttonInfo_KEA
            // 
            buttonInfo_KEA.Cursor = Cursors.Help;
            buttonInfo_KEA.FlatStyle = FlatStyle.Popup;
            buttonInfo_KEA.Location = new Point(364, 388);
            buttonInfo_KEA.Name = "buttonInfo_KEA";
            buttonInfo_KEA.Size = new Size(30, 31);
            buttonInfo_KEA.TabIndex = 4;
            buttonInfo_KEA.Text = "?";
            buttonInfo_KEA.UseVisualStyleBackColor = true;
            buttonInfo_KEA.Click += buttonInfo_KEA_Click;
            // 
            // buttonDone_KEA
            // 
            buttonDone_KEA.Cursor = Cursors.Hand;
            buttonDone_KEA.FlatStyle = FlatStyle.Popup;
            buttonDone_KEA.Location = new Point(400, 371);
            buttonDone_KEA.Name = "buttonDone_KEA";
            buttonDone_KEA.Size = new Size(120, 48);
            buttonDone_KEA.TabIndex = 3;
            buttonDone_KEA.Text = "Выполнить";
            buttonDone_KEA.UseVisualStyleBackColor = true;
            buttonDone_KEA.Click += buttonDone_KEA_Click;
            // 
            // textBoxOtvet_KEA
            // 
            textBoxOtvet_KEA.Location = new Point(420, 44);
            textBoxOtvet_KEA.Name = "textBoxOtvet_KEA";
            textBoxOtvet_KEA.Size = new Size(100, 29);
            textBoxOtvet_KEA.TabIndex = 2;
            textBoxOtvet_KEA.TextChanged += textBoxOtvet_KEA_TextChanged;
            // 
            // textBoxRes_KEA
            // 
            textBoxRes_KEA.BackColor = SystemColors.Menu;
            textBoxRes_KEA.BorderStyle = BorderStyle.None;
            textBoxRes_KEA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxRes_KEA.Location = new Point(420, 18);
            textBoxRes_KEA.Name = "textBoxRes_KEA";
            textBoxRes_KEA.ReadOnly = true;
            textBoxRes_KEA.Size = new Size(100, 20);
            textBoxRes_KEA.TabIndex = 1;
            textBoxRes_KEA.Text = "Результат:";
            // 
            // dataGridViewMtrx_KEA
            // 
            dataGridViewMtrx_KEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx_KEA.ColumnHeadersVisible = false;
            dataGridViewMtrx_KEA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewMtrx_KEA.Location = new Point(6, 22);
            dataGridViewMtrx_KEA.Name = "dataGridViewMtrx_KEA";
            dataGridViewMtrx_KEA.RowHeadersVisible = false;
            dataGridViewMtrx_KEA.Size = new Size(325, 324);
            dataGridViewMtrx_KEA.TabIndex = 0;
            dataGridViewMtrx_KEA.CellContentClick += dataGridViewMtrx_KEA_CellContentClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 200F;
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.FillWeight = 200F;
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.FillWeight = 200F;
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.FillWeight = 200F;
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.FillWeight = 200F;
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRes_KEA);
            Controls.Add(groupBoxCond_KEA);
            Name = "Form1";
            Text = "Спринт 6 | Таск 3 | Вариант 2 | Киселев Е. А.";
            Load += Form1_Load;
            groupBoxCond_KEA.ResumeLayout(false);
            groupBoxCond_KEA.PerformLayout();
            groupBoxRes_KEA.ResumeLayout(false);
            groupBoxRes_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_KEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_KEA;
        private GroupBox groupBoxRes_KEA;
        private TextBox textBoxRes_KEA;
        private DataGridView dataGridViewMtrx_KEA;
        private Button buttonInfo_KEA;
        private Button buttonDone_KEA;
        private TextBox textBoxOtvet_KEA;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
