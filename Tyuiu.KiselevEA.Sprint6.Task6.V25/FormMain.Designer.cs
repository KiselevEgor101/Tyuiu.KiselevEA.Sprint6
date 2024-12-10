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
            resources.ApplyResources(groupBoxCond_KEA, "groupBoxCond_KEA");
            groupBoxCond_KEA.Controls.Add(textBoxCond_KEA);
            groupBoxCond_KEA.Name = "groupBoxCond_KEA";
            groupBoxCond_KEA.TabStop = false;
            // 
            // textBoxCond_KEA
            // 
            resources.ApplyResources(textBoxCond_KEA, "textBoxCond_KEA");
            textBoxCond_KEA.BackColor = SystemColors.MenuBar;
            textBoxCond_KEA.BorderStyle = BorderStyle.None;
            textBoxCond_KEA.Name = "textBoxCond_KEA";
            textBoxCond_KEA.ReadOnly = true;
            textBoxCond_KEA.TextChanged += textBoxCond_KEA_TextChanged;
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
            resources.ApplyResources(buttonFile_KEA, "buttonFile_KEA");
            buttonFile_KEA.Cursor = Cursors.Hand;
            buttonFile_KEA.Name = "buttonFile_KEA";
            toolTipHelp_KEA.SetToolTip(buttonFile_KEA, resources.GetString("buttonFile_KEA.ToolTip"));
            buttonFile_KEA.UseVisualStyleBackColor = true;
            buttonFile_KEA.Click += buttonFile_KEA_Click;
            // 
            // buttonDone_KEA
            // 
            resources.ApplyResources(buttonDone_KEA, "buttonDone_KEA");
            buttonDone_KEA.Cursor = Cursors.Hand;
            buttonDone_KEA.Name = "buttonDone_KEA";
            buttonDone_KEA.UseVisualStyleBackColor = true;
            buttonDone_KEA.Click += buttonDone_KEA_Click;
            // 
            // buttonInfo_KEA
            // 
            resources.ApplyResources(buttonInfo_KEA, "buttonInfo_KEA");
            buttonInfo_KEA.Cursor = Cursors.Help;
            buttonInfo_KEA.Name = "buttonInfo_KEA";
            buttonInfo_KEA.UseVisualStyleBackColor = true;
            buttonInfo_KEA.Click += buttonInfo_KEA_Click;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(textBoxINdata_KEA);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxINdata_KEA
            // 
            resources.ApplyResources(textBoxINdata_KEA, "textBoxINdata_KEA");
            textBoxINdata_KEA.Name = "textBoxINdata_KEA";
            textBoxINdata_KEA.TextChanged += textBoxINdata_KEA_TextChanged;
            // 
            // groupBoxDataOut_KEA
            // 
            resources.ApplyResources(groupBoxDataOut_KEA, "groupBoxDataOut_KEA");
            groupBoxDataOut_KEA.Controls.Add(textBoxDataOut_KEA);
            groupBoxDataOut_KEA.Name = "groupBoxDataOut_KEA";
            groupBoxDataOut_KEA.TabStop = false;
            // 
            // textBoxDataOut_KEA
            // 
            resources.ApplyResources(textBoxDataOut_KEA, "textBoxDataOut_KEA");
            textBoxDataOut_KEA.Name = "textBoxDataOut_KEA";
            textBoxDataOut_KEA.TextChanged += textBoxDataOut_KEA_TextChanged;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxDataOut_KEA);
            Controls.Add(groupBox1);
            Controls.Add(buttonInfo_KEA);
            Controls.Add(buttonDone_KEA);
            Controls.Add(buttonFile_KEA);
            Controls.Add(groupBoxCond_KEA);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormMain";
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
