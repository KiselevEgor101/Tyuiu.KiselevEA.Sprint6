namespace Tyuiu.KiselevEA.Sprint6.Task2.V2
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
            groupBoxConditional_KEA = new GroupBox();
            textBoxConditional_KEA = new TextBox();
            groupBoxData_KEA = new GroupBox();
            textBoxStartStep_KEA = new TextBox();
            textBoxStopStep_KEA = new TextBox();
            textBoxStartStepData_KEA = new TextBox();
            textBoxStopStepData_KEA = new TextBox();
            ButtonClickResult_KEA = new Button();
            buttonInfo_KEA = new Button();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBoxConditional_KEA.SuspendLayout();
            groupBoxData_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConditional_KEA
            // 
            groupBoxConditional_KEA.Controls.Add(groupBox1);
            groupBoxConditional_KEA.Controls.Add(textBoxConditional_KEA);
            groupBoxConditional_KEA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxConditional_KEA.Location = new Point(11, 14);
            groupBoxConditional_KEA.Name = "groupBoxConditional_KEA";
            groupBoxConditional_KEA.Size = new Size(479, 284);
            groupBoxConditional_KEA.TabIndex = 0;
            groupBoxConditional_KEA.TabStop = false;
            groupBoxConditional_KEA.Text = "Условие";
            // 
            // textBoxConditional_KEA
            // 
            textBoxConditional_KEA.BackColor = SystemColors.Menu;
            textBoxConditional_KEA.BorderStyle = BorderStyle.None;
            textBoxConditional_KEA.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxConditional_KEA.Location = new Point(6, 22);
            textBoxConditional_KEA.Multiline = true;
            textBoxConditional_KEA.Name = "textBoxConditional_KEA";
            textBoxConditional_KEA.Size = new Size(446, 110);
            textBoxConditional_KEA.TabIndex = 0;
            textBoxConditional_KEA.Text = "Написать программу, которая выводит таблицу значений функции:\r\n F(x) = sin(x) + 2/(3x + 0.5) - 2cos(x) * 2x\r\nЗначения занести в DataGridView.";
            // 
            // groupBoxData_KEA
            // 
            groupBoxData_KEA.Controls.Add(buttonInfo_KEA);
            groupBoxData_KEA.Controls.Add(ButtonClickResult_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStopStepData_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStartStepData_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStopStep_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStartStep_KEA);
            groupBoxData_KEA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData_KEA.Location = new Point(12, 305);
            groupBoxData_KEA.Name = "groupBoxData_KEA";
            groupBoxData_KEA.Size = new Size(478, 133);
            groupBoxData_KEA.TabIndex = 1;
            groupBoxData_KEA.TabStop = false;
            groupBoxData_KEA.Text = "Ввод данных";
            // 
            // textBoxStartStep_KEA
            // 
            textBoxStartStep_KEA.BackColor = SystemColors.Menu;
            textBoxStartStep_KEA.BorderStyle = BorderStyle.None;
            textBoxStartStep_KEA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxStartStep_KEA.Location = new Point(12, 24);
            textBoxStartStep_KEA.Name = "textBoxStartStep_KEA";
            textBoxStartStep_KEA.Size = new Size(100, 20);
            textBoxStartStep_KEA.TabIndex = 0;
            textBoxStartStep_KEA.Text = "Старт шага:";
            // 
            // textBoxStopStep_KEA
            // 
            textBoxStopStep_KEA.BackColor = SystemColors.Menu;
            textBoxStopStep_KEA.BorderStyle = BorderStyle.None;
            textBoxStopStep_KEA.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxStopStep_KEA.Location = new Point(118, 24);
            textBoxStopStep_KEA.Name = "textBoxStopStep_KEA";
            textBoxStopStep_KEA.Size = new Size(100, 20);
            textBoxStopStep_KEA.TabIndex = 1;
            textBoxStopStep_KEA.Text = "Конец шага:";
            // 
            // textBoxStartStepData_KEA
            // 
            textBoxStartStepData_KEA.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxStartStepData_KEA.Location = new Point(12, 50);
            textBoxStartStepData_KEA.Name = "textBoxStartStepData_KEA";
            textBoxStartStepData_KEA.Size = new Size(79, 23);
            textBoxStartStepData_KEA.TabIndex = 2;
            textBoxStartStepData_KEA.TextChanged += textBoxStartStepData_KEA_TextChanged;
            // 
            // textBoxStopStepData_KEA
            // 
            textBoxStopStepData_KEA.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxStopStepData_KEA.Location = new Point(118, 50);
            textBoxStopStepData_KEA.Name = "textBoxStopStepData_KEA";
            textBoxStopStepData_KEA.Size = new Size(79, 23);
            textBoxStopStepData_KEA.TabIndex = 3;
            textBoxStopStepData_KEA.TextChanged += textBoxStopStepData_KEA_TextChanged;
            // 
            // ButtonClickResult_KEA
            // 
            ButtonClickResult_KEA.BackColor = Color.SpringGreen;
            ButtonClickResult_KEA.Location = new Point(316, 62);
            ButtonClickResult_KEA.Name = "ButtonClickResult_KEA";
            ButtonClickResult_KEA.Size = new Size(156, 65);
            ButtonClickResult_KEA.TabIndex = 4;
            ButtonClickResult_KEA.Text = "Выполнить";
            ButtonClickResult_KEA.UseVisualStyleBackColor = false;
            ButtonClickResult_KEA.Click += ButtonClickResult_KEA_Click;
            // 
            // buttonInfo_KEA
            // 
            buttonInfo_KEA.BackColor = SystemColors.ActiveCaption;
            buttonInfo_KEA.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_KEA.Location = new Point(272, 90);
            buttonInfo_KEA.Name = "buttonInfo_KEA";
            buttonInfo_KEA.Size = new Size(38, 37);
            buttonInfo_KEA.TabIndex = 5;
            buttonInfo_KEA.Text = "?";
            buttonInfo_KEA.UseVisualStyleBackColor = false;
            buttonInfo_KEA.Click += buttonInfo_KEA_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridView1.Location = new Point(15, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(204, 349);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(500, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 177);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(496, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 414);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxData_KEA);
            Controls.Add(groupBoxConditional_KEA);
            Name = "Form1";
            Text = "| СПРИНТ 6 | ТАСК 2 | ВАРИАНТ 2 | КИСЕЛЕВ Е. А. |";
            groupBoxConditional_KEA.ResumeLayout(false);
            groupBoxConditional_KEA.PerformLayout();
            groupBoxData_KEA.ResumeLayout(false);
            groupBoxData_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditional_KEA;
        private TextBox textBoxConditional_KEA;
        private GroupBox groupBoxData_KEA;
        private TextBox textBoxStartStep_KEA;
        private Button ButtonClickResult_KEA;
        private TextBox textBoxStopStepData_KEA;
        private TextBox textBoxStartStepData_KEA;
        private TextBox textBoxStopStep_KEA;
        private Button buttonInfo_KEA;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
