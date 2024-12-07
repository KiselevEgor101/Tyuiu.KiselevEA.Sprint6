namespace Tyuiu.KiselevEA.Sprint6.Task4.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxConditional_KEA = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxData_KEA = new GroupBox();
            textBoxStopStepData_KEA = new TextBox();
            textBoxStartStepData_KEA = new TextBox();
            textBoxStopStep_KEA = new TextBox();
            textBoxsStartStep_KEA = new TextBox();
            buttonInfo_KEA = new Button();
            buttonSave_KEA = new Button();
            buttonDone_KEA = new Button();
            groupBoxOut_KEA = new GroupBox();
            chart_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBox1 = new TextBox();
            groupBoxConditional_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxData_KEA.SuspendLayout();
            groupBoxOut_KEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_KEA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxConditional_KEA
            // 
            groupBoxConditional_KEA.Controls.Add(pictureBox1);
            groupBoxConditional_KEA.Location = new Point(12, 11);
            groupBoxConditional_KEA.Name = "groupBoxConditional_KEA";
            groupBoxConditional_KEA.Size = new Size(629, 106);
            groupBoxConditional_KEA.TabIndex = 0;
            groupBoxConditional_KEA.TabStop = false;
            groupBoxConditional_KEA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 69);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxData_KEA
            // 
            groupBoxData_KEA.Controls.Add(textBoxStopStepData_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStartStepData_KEA);
            groupBoxData_KEA.Controls.Add(textBoxStopStep_KEA);
            groupBoxData_KEA.Controls.Add(textBoxsStartStep_KEA);
            groupBoxData_KEA.Controls.Add(buttonInfo_KEA);
            groupBoxData_KEA.Controls.Add(buttonSave_KEA);
            groupBoxData_KEA.Controls.Add(buttonDone_KEA);
            groupBoxData_KEA.Location = new Point(647, 12);
            groupBoxData_KEA.Name = "groupBoxData_KEA";
            groupBoxData_KEA.Size = new Size(458, 107);
            groupBoxData_KEA.TabIndex = 1;
            groupBoxData_KEA.TabStop = false;
            groupBoxData_KEA.Text = "Ввод данных";
            groupBoxData_KEA.Enter += groupBoxData_KEA_Enter;
            // 
            // textBoxStopStepData_KEA
            // 
            textBoxStopStepData_KEA.Location = new Point(113, 42);
            textBoxStopStepData_KEA.Name = "textBoxStopStepData_KEA";
            textBoxStopStepData_KEA.Size = new Size(93, 23);
            textBoxStopStepData_KEA.TabIndex = 6;
            textBoxStopStepData_KEA.TextChanged += textBoxStopStepData_KEA_TextChanged;
            // 
            // textBoxStartStepData_KEA
            // 
            textBoxStartStepData_KEA.Location = new Point(6, 42);
            textBoxStartStepData_KEA.Name = "textBoxStartStepData_KEA";
            textBoxStartStepData_KEA.Size = new Size(93, 23);
            textBoxStartStepData_KEA.TabIndex = 5;
            textBoxStartStepData_KEA.TextChanged += textBoxStartStepData_KEA_TextChanged;
            // 
            // textBoxStopStep_KEA
            // 
            textBoxStopStep_KEA.BackColor = SystemColors.Menu;
            textBoxStopStep_KEA.BorderStyle = BorderStyle.None;
            textBoxStopStep_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxStopStep_KEA.Location = new Point(113, 18);
            textBoxStopStep_KEA.Name = "textBoxStopStep_KEA";
            textBoxStopStep_KEA.Size = new Size(100, 22);
            textBoxStopStep_KEA.TabIndex = 4;
            textBoxStopStep_KEA.Text = "Конец шага:";
            // 
            // textBoxsStartStep_KEA
            // 
            textBoxsStartStep_KEA.BackColor = SystemColors.Menu;
            textBoxsStartStep_KEA.BorderStyle = BorderStyle.None;
            textBoxsStartStep_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxsStartStep_KEA.Location = new Point(7, 18);
            textBoxsStartStep_KEA.Name = "textBoxsStartStep_KEA";
            textBoxsStartStep_KEA.Size = new Size(100, 22);
            textBoxsStartStep_KEA.TabIndex = 3;
            textBoxsStartStep_KEA.Text = "Старт шага:";
            // 
            // buttonInfo_KEA
            // 
            buttonInfo_KEA.BackColor = Color.PeachPuff;
            buttonInfo_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_KEA.Location = new Point(187, 66);
            buttonInfo_KEA.Name = "buttonInfo_KEA";
            buttonInfo_KEA.Size = new Size(26, 29);
            buttonInfo_KEA.TabIndex = 2;
            buttonInfo_KEA.Text = "?";
            buttonInfo_KEA.UseVisualStyleBackColor = false;
            buttonInfo_KEA.Click += buttonInfo_KEA_Click;
            // 
            // buttonSave_KEA
            // 
            buttonSave_KEA.BackColor = Color.CornflowerBlue;
            buttonSave_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_KEA.Location = new Point(340, 38);
            buttonSave_KEA.Name = "buttonSave_KEA";
            buttonSave_KEA.Size = new Size(115, 57);
            buttonSave_KEA.TabIndex = 1;
            buttonSave_KEA.Text = "Сохранить";
            buttonSave_KEA.UseVisualStyleBackColor = false;
            buttonSave_KEA.Click += buttonSave_KEA_Click;
            // 
            // buttonDone_KEA
            // 
            buttonDone_KEA.BackColor = Color.LawnGreen;
            buttonDone_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KEA.Location = new Point(219, 38);
            buttonDone_KEA.Name = "buttonDone_KEA";
            buttonDone_KEA.Size = new Size(115, 57);
            buttonDone_KEA.TabIndex = 0;
            buttonDone_KEA.Text = "Выполнить";
            buttonDone_KEA.UseVisualStyleBackColor = false;
            buttonDone_KEA.Click += buttonDone_KEA_Click;
            buttonDone_KEA.MouseEnter += buttonDone_KEA_Click;
            // 
            // groupBoxOut_KEA
            // 
            groupBoxOut_KEA.Controls.Add(chart_KEA);
            groupBoxOut_KEA.Controls.Add(textBox1);
            groupBoxOut_KEA.Location = new Point(12, 123);
            groupBoxOut_KEA.Name = "groupBoxOut_KEA";
            groupBoxOut_KEA.Size = new Size(1264, 342);
            groupBoxOut_KEA.TabIndex = 2;
            groupBoxOut_KEA.TabStop = false;
            groupBoxOut_KEA.Text = "Вывод данных";
            // 
            // chart_KEA
            // 
            chartArea2.Name = "ChartArea1";
            chart_KEA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_KEA.Legends.Add(legend2);
            chart_KEA.Location = new Point(207, 4);
            chart_KEA.Name = "chart_KEA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_KEA.Series.Add(series2);
            chart_KEA.Size = new Size(1035, 340);
            chart_KEA.TabIndex = 2;
            chart_KEA.Text = "chart1";
            chart_KEA.Click += chart_KEA_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(9, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 311);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 477);
            Controls.Add(groupBoxOut_KEA);
            Controls.Add(groupBoxData_KEA);
            Controls.Add(groupBoxConditional_KEA);
            Name = "Form1";
            Text = "Спринт 6 | Таск 4 | Вариант 15 | Киселев Е. А.";
            groupBoxConditional_KEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxData_KEA.ResumeLayout(false);
            groupBoxData_KEA.PerformLayout();
            groupBoxOut_KEA.ResumeLayout(false);
            groupBoxOut_KEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_KEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConditional_KEA;
        private PictureBox pictureBox1;
        private GroupBox groupBoxData_KEA;
        private Button buttonInfo_KEA;
        private Button buttonSave_KEA;
        private Button buttonDone_KEA;
        private TextBox textBoxStartStepData_KEA;
        private TextBox textBoxStopStep_KEA;
        private TextBox textBoxsStartStep_KEA;
        private TextBox textBoxStopStepData_KEA;
        private GroupBox groupBoxOut_KEA;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KEA;
    }
}
