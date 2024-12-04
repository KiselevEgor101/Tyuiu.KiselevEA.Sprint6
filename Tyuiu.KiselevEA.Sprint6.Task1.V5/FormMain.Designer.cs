namespace Tyuiu.KiselevEA.Sprint6.Task1.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxConditional_KEA = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2Result_KEA = new GroupBox();
            textBoxResult_KEA = new TextBox();
            groupBoxData_KEA = new GroupBox();
            buttonDone_KEA = new Button();
            buttonInfo_KEA = new Button();
            textBoxParamStop_KEA = new TextBox();
            textBoxParamStart_KEA = new TextBox();
            textBoxStopStep_KEA = new TextBox();
            textBoxStartStep_KEA = new TextBox();
            groupBoxConditional_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2Result_KEA.SuspendLayout();
            groupBoxData_KEA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConditional_KEA
            // 
            groupBoxConditional_KEA.Controls.Add(pictureBox1);
            groupBoxConditional_KEA.Location = new Point(12, 12);
            groupBoxConditional_KEA.Name = "groupBoxConditional_KEA";
            groupBoxConditional_KEA.Size = new Size(528, 321);
            groupBoxConditional_KEA.TabIndex = 0;
            groupBoxConditional_KEA.TabStop = false;
            groupBoxConditional_KEA.Text = "Условие";
            groupBoxConditional_KEA.Enter += groupBoxConditional_KEA_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 85);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2Result_KEA
            // 
            groupBox2Result_KEA.Controls.Add(textBoxResult_KEA);
            groupBox2Result_KEA.Location = new Point(555, 12);
            groupBox2Result_KEA.Name = "groupBox2Result_KEA";
            groupBox2Result_KEA.Size = new Size(233, 426);
            groupBox2Result_KEA.TabIndex = 1;
            groupBox2Result_KEA.TabStop = false;
            groupBox2Result_KEA.Text = "Результат";
            groupBox2Result_KEA.Enter += groupBox2Result_KEA_Enter;
            // 
            // textBoxResult_KEA
            // 
            textBoxResult_KEA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KEA.Location = new Point(6, 17);
            textBoxResult_KEA.Multiline = true;
            textBoxResult_KEA.Name = "textBoxResult_KEA";
            textBoxResult_KEA.Size = new Size(221, 382);
            textBoxResult_KEA.TabIndex = 1;
            textBoxResult_KEA.TextChanged += textBoxResult_KEA_TextChanged;
            // 
            // groupBoxData_KEA
            // 
            groupBoxData_KEA.Controls.Add(buttonDone_KEA);
            groupBoxData_KEA.Controls.Add(buttonInfo_KEA);
            groupBoxData_KEA.Controls.Add(textBoxParamStop_KEA);
            groupBoxData_KEA.Controls.Add(textBoxParamStart_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStopStep_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStartStep_KEA);
            groupBoxData_KEA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData_KEA.Location = new Point(12, 339);
            groupBoxData_KEA.Name = "groupBoxData_KEA";
            groupBoxData_KEA.Size = new Size(528, 99);
            groupBoxData_KEA.TabIndex = 2;
            groupBoxData_KEA.TabStop = false;
            groupBoxData_KEA.Text = "Ввод данных";
            // 
            // buttonDone_KEA
            // 
            buttonDone_KEA.BackColor = Color.Lime;
            buttonDone_KEA.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonDone_KEA.Location = new Point(366, 28);
            buttonDone_KEA.Name = "buttonDone_KEA";
            buttonDone_KEA.Size = new Size(156, 65);
            buttonDone_KEA.TabIndex = 5;
            buttonDone_KEA.Text = "Выполнить";
            buttonDone_KEA.UseVisualStyleBackColor = false;
            buttonDone_KEA.Click += buttonDone_KEA_Click;
            // 
            // buttonInfo_KEA
            // 
            buttonInfo_KEA.BackColor = SystemColors.HotTrack;
            buttonInfo_KEA.BackgroundImageLayout = ImageLayout.None;
            buttonInfo_KEA.Cursor = Cursors.Help;
            buttonInfo_KEA.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonInfo_KEA.ForeColor = SystemColors.Desktop;
            buttonInfo_KEA.Location = new Point(327, 55);
            buttonInfo_KEA.Name = "buttonInfo_KEA";
            buttonInfo_KEA.Size = new Size(33, 38);
            buttonInfo_KEA.TabIndex = 4;
            buttonInfo_KEA.Text = "?";
            buttonInfo_KEA.UseVisualStyleBackColor = false;
            buttonInfo_KEA.Click += buttonInfo_KEA_Click;
            // 
            // textBoxParamStop_KEA
            // 
            textBoxParamStop_KEA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxParamStop_KEA.Location = new Point(141, 43);
            textBoxParamStop_KEA.Name = "textBoxParamStop_KEA";
            textBoxParamStop_KEA.Size = new Size(90, 23);
            textBoxParamStop_KEA.TabIndex = 3;
            textBoxParamStop_KEA.TextChanged += textBoxParamStop_KEA_TextChanged;
            // 
            // textBoxParamStart_KEA
            // 
            textBoxParamStart_KEA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxParamStart_KEA.Location = new Point(9, 43);
            textBoxParamStart_KEA.Name = "textBoxParamStart_KEA";
            textBoxParamStart_KEA.Size = new Size(85, 23);
            textBoxParamStart_KEA.TabIndex = 2;
            textBoxParamStart_KEA.TextChanged += textBoxParamStart_KEA_TextChanged;
            // 
            // textBoxStopStep_KEA
            // 
            textBoxStopStep_KEA.BackColor = SystemColors.Menu;
            textBoxStopStep_KEA.BorderStyle = BorderStyle.None;
            textBoxStopStep_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxStopStep_KEA.Location = new Point(141, 20);
            textBoxStopStep_KEA.Name = "textBoxStopStep_KEA";
            textBoxStopStep_KEA.Size = new Size(100, 22);
            textBoxStopStep_KEA.TabIndex = 1;
            textBoxStopStep_KEA.Text = "Конец Шага:";
            // 
            // textBoxStartStep_KEA
            // 
            textBoxStartStep_KEA.BackColor = SystemColors.Menu;
            textBoxStartStep_KEA.BorderStyle = BorderStyle.None;
            textBoxStartStep_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxStartStep_KEA.Location = new Point(10, 20);
            textBoxStartStep_KEA.Name = "textBoxStartStep_KEA";
            textBoxStartStep_KEA.Size = new Size(100, 22);
            textBoxStartStep_KEA.TabIndex = 0;
            textBoxStartStep_KEA.Text = "Старт Шага:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxData_KEA);
            Controls.Add(groupBox2Result_KEA);
            Controls.Add(groupBoxConditional_KEA);
            Name = "FormMain";
            Text = "Спринт 6  | Таск 1 | Вариант 5 | Киселев Е. А.";
            Load += FormMain_Load;
            groupBoxConditional_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2Result_KEA.ResumeLayout(false);
            groupBox2Result_KEA.PerformLayout();
            groupBoxData_KEA.ResumeLayout(false);
            groupBoxData_KEA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditional_KEA;
        private GroupBox groupBox2Result_KEA;
        private GroupBox groupBoxData_KEA;
        private TextBox textBoxStopStep_KEA;
        private TextBox textBoxStartStep_KEA;
        private PictureBox pictureBox1;
        private Button buttonInfo_KEA;
        private TextBox textBoxParamStop_KEA;
        private TextBox textBoxParamStart_KEA;
        private Button buttonDone_KEA;
        private TextBox textBoxResult_KEA;
    }
}
