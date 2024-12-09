namespace Tyuiu.KiselevEA.Sprint6.Task6.V25
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCond_KEA = new GroupBox();
            textBoxCond_KEA = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            toolTipHelp_KEA = new ToolTip(components);
            buttonFile_KEA = new Button();
            buttonDone_KEA = new Button();
            buttonInfo_KEA = new Button();
            groupBox1 = new GroupBox();
            textBoxINdata_KEA = new TextBox();
            groupBoxDataOut_KEA = new GroupBox();
            textBoxDataOut_KEA = new TextBox();
            groupBoxCond_KEA.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxDataOut_KEA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCond_KEA
            // 
            groupBoxCond_KEA.Controls.Add(textBoxCond_KEA);
            groupBoxCond_KEA.Location = new Point(12, 77);
            groupBoxCond_KEA.Name = "groupBoxCond_KEA";
            groupBoxCond_KEA.Size = new Size(915, 100);
            groupBoxCond_KEA.TabIndex = 0;
            groupBoxCond_KEA.TabStop = false;
            groupBoxCond_KEA.Text = "Условие";
            // 
            // textBoxCond_KEA
            // 
            textBoxCond_KEA.BackColor = SystemColors.MenuBar;
            textBoxCond_KEA.BorderStyle = BorderStyle.None;
            textBoxCond_KEA.Location = new Point(6, 19);
            textBoxCond_KEA.Multiline = true;
            textBoxCond_KEA.Name = "textBoxCond_KEA";
            textBoxCond_KEA.Size = new Size(600, 75);
            textBoxCond_KEA.TabIndex = 0;
            textBoxCond_KEA.Text = resources.GetString("textBoxCond_KEA.Text");
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog_KEA";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // toolTipHelp_KEA
            // 
            toolTipHelp_KEA.Tag = "123";
            // 
            // buttonFile_KEA
            // 
            buttonFile_KEA.BackgroundImage = (Image)resources.GetObject("buttonFile_KEA.BackgroundImage");
            buttonFile_KEA.BackgroundImageLayout = ImageLayout.Center;
            buttonFile_KEA.Cursor = Cursors.Hand;
            buttonFile_KEA.Location = new Point(12, 8);
            buttonFile_KEA.Name = "buttonFile_KEA";
            buttonFile_KEA.Size = new Size(89, 63);
            buttonFile_KEA.TabIndex = 1;
            toolTipHelp_KEA.SetToolTip(buttonFile_KEA, "Открыть файл\r\nВыберите файл в папке\r\n");
            buttonFile_KEA.UseVisualStyleBackColor = true;
            buttonFile_KEA.Click += buttonFile_KEA_Click;
            // 
            // buttonDone_KEA
            // 
            buttonDone_KEA.BackgroundImage = (Image)resources.GetObject("buttonDone_KEA.BackgroundImage");
            buttonDone_KEA.BackgroundImageLayout = ImageLayout.Center;
            buttonDone_KEA.Cursor = Cursors.Hand;
            buttonDone_KEA.Location = new Point(107, 8);
            buttonDone_KEA.Name = "buttonDone_KEA";
            buttonDone_KEA.Size = new Size(89, 63);
            buttonDone_KEA.TabIndex = 2;
            buttonDone_KEA.UseVisualStyleBackColor = true;
            buttonDone_KEA.Click += buttonDone_KEA_Click;
            // 
            // buttonInfo_KEA
            // 
            buttonInfo_KEA.BackgroundImage = (Image)resources.GetObject("buttonInfo_KEA.BackgroundImage");
            buttonInfo_KEA.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_KEA.Cursor = Cursors.Help;
            buttonInfo_KEA.Location = new Point(838, 8);
            buttonInfo_KEA.Name = "buttonInfo_KEA";
            buttonInfo_KEA.Size = new Size(89, 63);
            buttonInfo_KEA.TabIndex = 3;
            buttonInfo_KEA.UseVisualStyleBackColor = true;
            buttonInfo_KEA.Click += buttonInfo_KEA_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxINdata_KEA);
            groupBox1.Location = new Point(14, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 296);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxINdata_KEA
            // 
            textBoxINdata_KEA.Location = new Point(9, 21);
            textBoxINdata_KEA.Multiline = true;
            textBoxINdata_KEA.Name = "textBoxINdata_KEA";
            textBoxINdata_KEA.Size = new Size(434, 269);
            textBoxINdata_KEA.TabIndex = 0;
            textBoxINdata_KEA.TextChanged += textBoxINdata_KEA_TextChanged;
            // 
            // groupBoxDataOut_KEA
            // 
            groupBoxDataOut_KEA.Controls.Add(textBoxDataOut_KEA);
            groupBoxDataOut_KEA.Location = new Point(467, 187);
            groupBoxDataOut_KEA.Name = "groupBoxDataOut_KEA";
            groupBoxDataOut_KEA.Size = new Size(460, 280);
            groupBoxDataOut_KEA.TabIndex = 5;
            groupBoxDataOut_KEA.TabStop = false;
            groupBoxDataOut_KEA.Text = "Вывод";
            // 
            // textBoxDataOut_KEA
            // 
            textBoxDataOut_KEA.Location = new Point(6, 20);
            textBoxDataOut_KEA.Multiline = true;
            textBoxDataOut_KEA.Name = "textBoxDataOut_KEA";
            textBoxDataOut_KEA.Size = new Size(448, 254);
            textBoxDataOut_KEA.TabIndex = 0;
            textBoxDataOut_KEA.TextChanged += textBoxDataOut_KEA_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 485);
            Controls.Add(groupBoxDataOut_KEA);
            Controls.Add(groupBox1);
            Controls.Add(buttonInfo_KEA);
            Controls.Add(buttonDone_KEA);
            Controls.Add(buttonFile_KEA);
            Controls.Add(groupBoxCond_KEA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 25 | Киселев Е. А.";
            groupBoxCond_KEA.ResumeLayout(false);
            groupBoxCond_KEA.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxDataOut_KEA.ResumeLayout(false);
            groupBoxDataOut_KEA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_KEA;
        private TextBox textBoxCond_KEA;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTipHelp_KEA;
        private Button buttonFile_KEA;
        private Button buttonDone_KEA;
        private Button buttonInfo_KEA;
        private GroupBox groupBox1;
        private TextBox textBoxINdata_KEA;
        private GroupBox groupBoxDataOut_KEA;
        private TextBox textBoxDataOut_KEA;
    }
}
