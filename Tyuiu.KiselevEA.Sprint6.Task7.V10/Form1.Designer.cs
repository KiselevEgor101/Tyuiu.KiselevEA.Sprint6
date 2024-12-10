namespace Tyuiu.KiselevEA.Sprint6.Task7.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBoxConditional_KEA = new TextBox();
            buttonOpen_KEA = new Button();
            buttonDone_KEA = new Button();
            buttonSave_KEA = new Button();
            buttonAbout_KEA = new Button();
            groupBoxIN_KEA = new GroupBox();
            dataGridViewIN_KEA = new DataGridView();
            groupBoxOUT_KEA = new GroupBox();
            dataGridViewOUT_KEA = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBoxIN_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIN_KEA).BeginInit();
            groupBoxOUT_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOUT_KEA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxConditional_KEA);
            groupBox1.Location = new Point(6, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBoxConditional_KEA
            // 
            textBoxConditional_KEA.BackColor = SystemColors.MenuBar;
            textBoxConditional_KEA.BorderStyle = BorderStyle.None;
            textBoxConditional_KEA.Location = new Point(12, 22);
            textBoxConditional_KEA.Multiline = true;
            textBoxConditional_KEA.Name = "textBoxConditional_KEA";
            textBoxConditional_KEA.Size = new Size(764, 72);
            textBoxConditional_KEA.TabIndex = 0;
            textBoxConditional_KEA.Text = resources.GetString("textBoxConditional_KEA.Text");
            // 
            // buttonOpen_KEA
            // 
            buttonOpen_KEA.BackgroundImage = (Image)resources.GetObject("buttonOpen_KEA.BackgroundImage");
            buttonOpen_KEA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpen_KEA.Location = new Point(14, 9);
            buttonOpen_KEA.Name = "buttonOpen_KEA";
            buttonOpen_KEA.Size = new Size(91, 65);
            buttonOpen_KEA.TabIndex = 1;
            buttonOpen_KEA.UseVisualStyleBackColor = true;
            buttonOpen_KEA.Click += buttonOpen_KEA_Click;
            // 
            // buttonDone_KEA
            // 
            buttonDone_KEA.BackgroundImage = (Image)resources.GetObject("buttonDone_KEA.BackgroundImage");
            buttonDone_KEA.BackgroundImageLayout = ImageLayout.Center;
            buttonDone_KEA.Enabled = false;
            buttonDone_KEA.Location = new Point(111, 8);
            buttonDone_KEA.Name = "buttonDone_KEA";
            buttonDone_KEA.Size = new Size(95, 66);
            buttonDone_KEA.TabIndex = 2;
            buttonDone_KEA.UseVisualStyleBackColor = true;
            buttonDone_KEA.Click += buttonDone_KEA_Click;
            // 
            // buttonSave_KEA
            // 
            buttonSave_KEA.BackgroundImage = (Image)resources.GetObject("buttonSave_KEA.BackgroundImage");
            buttonSave_KEA.BackgroundImageLayout = ImageLayout.Center;
            buttonSave_KEA.Enabled = false;
            buttonSave_KEA.Location = new Point(212, 8);
            buttonSave_KEA.Name = "buttonSave_KEA";
            buttonSave_KEA.Size = new Size(95, 66);
            buttonSave_KEA.TabIndex = 3;
            buttonSave_KEA.UseVisualStyleBackColor = true;
            buttonSave_KEA.Click += buttonSave_KEA_Click;
            // 
            // buttonAbout_KEA
            // 
            buttonAbout_KEA.BackgroundImage = (Image)resources.GetObject("buttonAbout_KEA.BackgroundImage");
            buttonAbout_KEA.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_KEA.Location = new Point(688, 8);
            buttonAbout_KEA.Name = "buttonAbout_KEA";
            buttonAbout_KEA.Size = new Size(95, 65);
            buttonAbout_KEA.TabIndex = 4;
            buttonAbout_KEA.UseVisualStyleBackColor = true;
            buttonAbout_KEA.Click += buttonAbout_KEA_Click;
            // 
            // groupBoxIN_KEA
            // 
            groupBoxIN_KEA.Controls.Add(dataGridViewIN_KEA);
            groupBoxIN_KEA.Location = new Point(12, 204);
            groupBoxIN_KEA.Name = "groupBoxIN_KEA";
            groupBoxIN_KEA.Size = new Size(356, 338);
            groupBoxIN_KEA.TabIndex = 5;
            groupBoxIN_KEA.TabStop = false;
            groupBoxIN_KEA.Text = "Ввод";
            groupBoxIN_KEA.Enter += groupBoxIN_KEA_Enter;
            // 
            // dataGridViewIN_KEA
            // 
            dataGridViewIN_KEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIN_KEA.Location = new Point(7, 22);
            dataGridViewIN_KEA.Name = "dataGridViewIN_KEA";
            dataGridViewIN_KEA.Size = new Size(343, 310);
            dataGridViewIN_KEA.TabIndex = 0;
            dataGridViewIN_KEA.CellContentClick += dataGridViewIN_KEA_CellContentClick;
            // 
            // groupBoxOUT_KEA
            // 
            groupBoxOUT_KEA.Controls.Add(dataGridViewOUT_KEA);
            groupBoxOUT_KEA.Location = new Point(381, 204);
            groupBoxOUT_KEA.Name = "groupBoxOUT_KEA";
            groupBoxOUT_KEA.Size = new Size(402, 338);
            groupBoxOUT_KEA.TabIndex = 6;
            groupBoxOUT_KEA.TabStop = false;
            groupBoxOUT_KEA.Text = "Вывод";
            // 
            // dataGridViewOUT_KEA
            // 
            dataGridViewOUT_KEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOUT_KEA.Location = new Point(9, 22);
            dataGridViewOUT_KEA.Name = "dataGridViewOUT_KEA";
            dataGridViewOUT_KEA.Size = new Size(387, 310);
            dataGridViewOUT_KEA.TabIndex = 0;
            dataGridViewOUT_KEA.CellContentClick += dataGridViewOUT_KEA_CellContentClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 554);
            Controls.Add(groupBoxOUT_KEA);
            Controls.Add(groupBoxIN_KEA);
            Controls.Add(buttonAbout_KEA);
            Controls.Add(buttonSave_KEA);
            Controls.Add(buttonDone_KEA);
            Controls.Add(buttonOpen_KEA);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxIN_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIN_KEA).EndInit();
            groupBoxOUT_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOUT_KEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxConditional_KEA;
        private Button buttonOpen_KEA;
        private Button buttonDone_KEA;
        private Button buttonSave_KEA;
        private Button buttonAbout_KEA;
        private GroupBox groupBoxIN_KEA;
        private DataGridView dataGridViewIN_KEA;
        private GroupBox groupBoxOUT_KEA;
        private DataGridView dataGridViewOUT_KEA;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
