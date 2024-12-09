namespace Tyuiu.KiselevEA.Sprint6.Task5.V8
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            OpenFile = new Button();
            Info = new Button();
            Done = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(OpenFile);
            groupBox1.Controls.Add(Info);
            groupBox1.Controls.Add(Done);
            groupBox1.Location = new Point(15, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(13, 21);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(421, 87);
            textBox2.TabIndex = 3;
            textBox2.Text = "Прочитать данные из файла InPutFileTask5V8.txt.\r\nВывести в dataGridView. \r\nДан список из чисел. Вывести все числа, меньше 0.";
            // 
            // OpenFile
            // 
            OpenFile.BackColor = SystemColors.ActiveCaption;
            OpenFile.FlatStyle = FlatStyle.Popup;
            OpenFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OpenFile.ForeColor = SystemColors.Desktop;
            OpenFile.Location = new Point(551, 33);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(105, 63);
            OpenFile.TabIndex = 2;
            OpenFile.Text = "Открыть Файл";
            OpenFile.UseVisualStyleBackColor = false;
            OpenFile.Click += OpenFile_Click;
            
            // 
            // Info
            // 
            Info.BackColor = Color.DarkSeaGreen;
            Info.FlatStyle = FlatStyle.Popup;
            Info.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Info.Location = new Point(662, 33);
            Info.Name = "Info";
            Info.Size = new Size(105, 63);
            Info.TabIndex = 1;
            Info.Text = "Справка";
            Info.UseVisualStyleBackColor = false;
            Info.Click += Info_Click;
            // 
            // Done
            // 
            Done.BackColor = Color.YellowGreen;
            Done.FlatStyle = FlatStyle.Popup;
            Done.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Done.Location = new Point(440, 33);
            Done.Name = "Done";
            Done.Size = new Size(105, 63);
            Done.TabIndex = 0;
            Done.Text = "Выполнить";
            Done.UseVisualStyleBackColor = false;
            Done.Click += Done_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(17, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 314);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(222, 286);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 4 | Вариант 15 | Киселев Е. А.";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button OpenFile;
        private Button Info;
        private Button Done;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
    }
}
