namespace Tyuiu.GridinAE.Sprint6.Task6.V28
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
            panelButtons_GAE = new Panel();
            buttonHelp_GAE = new Button();
            buttonExecute_GAE = new Button();
            buttonOpenFile_GAE = new Button();
            groupBoxTask_GAE = new GroupBox();
            textBoxTask_GAE = new TextBox();
            labelInput_GAE = new Label();
            labelInputFileName = new Label();
            textBoxIn_GAE = new TextBox();
            labelOutput_GAE = new Label();
            textBoxOut_GAE = new TextBox();
            openFileDialogTask_GAE = new OpenFileDialog();
            toolTip_GAE = new ToolTip(components);
            panelButtons_GAE.SuspendLayout();
            groupBoxTask_GAE.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_GAE
            // 
            panelButtons_GAE.AutoSize = true;
            panelButtons_GAE.BackColor = SystemColors.Control;
            panelButtons_GAE.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_GAE.Controls.Add(buttonHelp_GAE);
            panelButtons_GAE.Controls.Add(buttonExecute_GAE);
            panelButtons_GAE.Controls.Add(buttonOpenFile_GAE);
            panelButtons_GAE.Dock = DockStyle.Top;
            panelButtons_GAE.Location = new Point(0, 0);
            panelButtons_GAE.Name = "panelButtons_GAE";
            panelButtons_GAE.Size = new Size(800, 80);
            panelButtons_GAE.TabIndex = 0;
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAE.FlatStyle = FlatStyle.Popup;
            buttonHelp_GAE.Image = (Image)resources.GetObject("buttonHelp_GAE.Image");
            buttonHelp_GAE.Location = new Point(703, 3);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(90, 70);
            buttonHelp_GAE.TabIndex = 2;
            toolTip_GAE.SetToolTip(buttonHelp_GAE, "О программе");
            buttonHelp_GAE.UseVisualStyleBackColor = true;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // buttonExecute_GAE
            // 
            buttonExecute_GAE.Enabled = false;
            buttonExecute_GAE.FlatStyle = FlatStyle.Popup;
            buttonExecute_GAE.Image = (Image)resources.GetObject("buttonExecute_GAE.Image");
            buttonExecute_GAE.Location = new Point(99, 3);
            buttonExecute_GAE.Name = "buttonExecute_GAE";
            buttonExecute_GAE.Size = new Size(90, 70);
            buttonExecute_GAE.TabIndex = 1;
            toolTip_GAE.SetToolTip(buttonExecute_GAE, "Выполнить");
            buttonExecute_GAE.UseVisualStyleBackColor = true;
            buttonExecute_GAE.Click += buttonExecute_GAE_Click;
            // 
            // buttonOpenFile_GAE
            // 
            buttonOpenFile_GAE.FlatStyle = FlatStyle.Popup;
            buttonOpenFile_GAE.Image = (Image)resources.GetObject("buttonOpenFile_GAE.Image");
            buttonOpenFile_GAE.Location = new Point(3, 3);
            buttonOpenFile_GAE.Name = "buttonOpenFile_GAE";
            buttonOpenFile_GAE.Size = new Size(90, 70);
            buttonOpenFile_GAE.TabIndex = 0;
            toolTip_GAE.SetToolTip(buttonOpenFile_GAE, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_GAE.UseVisualStyleBackColor = true;
            buttonOpenFile_GAE.Click += buttonOpenFile_GAE_Click;
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_GAE.AutoSize = true;
            groupBoxTask_GAE.Controls.Add(textBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(12, 86);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(776, 123);
            groupBoxTask_GAE.TabIndex = 1;
            groupBoxTask_GAE.TabStop = false;
            groupBoxTask_GAE.Text = "Условие";
            // 
            // textBoxTask_GAE
            // 
            textBoxTask_GAE.Dock = DockStyle.Fill;
            textBoxTask_GAE.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_GAE.Location = new Point(3, 23);
            textBoxTask_GAE.Multiline = true;
            textBoxTask_GAE.Name = "textBoxTask_GAE";
            textBoxTask_GAE.ReadOnly = true;
            textBoxTask_GAE.Size = new Size(770, 97);
            textBoxTask_GAE.TabIndex = 0;
            textBoxTask_GAE.Text = resources.GetString("textBoxTask_GAE.Text");
            // 
            // labelInput_GAE
            // 
            labelInput_GAE.AutoSize = true;
            labelInput_GAE.Location = new Point(12, 212);
            labelInput_GAE.Name = "labelInput_GAE";
            labelInput_GAE.Size = new Size(46, 20);
            labelInput_GAE.TabIndex = 2;
            labelInput_GAE.Text = "Ввод:";
            // 
            // labelInputFileName
            // 
            labelInputFileName.AutoSize = true;
            labelInputFileName.Location = new Point(64, 212);
            labelInputFileName.Name = "labelInputFileName";
            labelInputFileName.Size = new Size(0, 20);
            labelInputFileName.TabIndex = 3;
            // 
            // textBoxIn_GAE
            // 
            textBoxIn_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_GAE.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn_GAE.Location = new Point(15, 235);
            textBoxIn_GAE.Multiline = true;
            textBoxIn_GAE.Name = "textBoxIn_GAE";
            textBoxIn_GAE.ScrollBars = ScrollBars.Vertical;
            textBoxIn_GAE.Size = new Size(422, 293);
            textBoxIn_GAE.TabIndex = 4;
            // 
            // labelOutput_GAE
            // 
            labelOutput_GAE.AutoSize = true;
            labelOutput_GAE.Location = new Point(443, 212);
            labelOutput_GAE.Name = "labelOutput_GAE";
            labelOutput_GAE.Size = new Size(57, 20);
            labelOutput_GAE.TabIndex = 5;
            labelOutput_GAE.Text = "Вывод:";
            // 
            // textBoxOut_GAE
            // 
            textBoxOut_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut_GAE.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOut_GAE.Location = new Point(443, 235);
            textBoxOut_GAE.Multiline = true;
            textBoxOut_GAE.Name = "textBoxOut_GAE";
            textBoxOut_GAE.ScrollBars = ScrollBars.Vertical;
            textBoxOut_GAE.Size = new Size(345, 293);
            textBoxOut_GAE.TabIndex = 6;
            // 
            // openFileDialogTask_GAE
            // 
            openFileDialogTask_GAE.FileName = "InPutDataFileTask6V28.txt";
            // 
            // toolTip_GAE
            // 
            toolTip_GAE.ToolTipIcon = ToolTipIcon.Info;
            toolTip_GAE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(textBoxOut_GAE);
            Controls.Add(labelOutput_GAE);
            Controls.Add(textBoxIn_GAE);
            Controls.Add(labelInputFileName);
            Controls.Add(labelInput_GAE);
            Controls.Add(groupBoxTask_GAE);
            Controls.Add(panelButtons_GAE);
            MinimumSize = new Size(818, 497);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 28 | Гридин А. Е.";
            panelButtons_GAE.ResumeLayout(false);
            groupBoxTask_GAE.ResumeLayout(false);
            groupBoxTask_GAE.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelButtons_GAE;
        private Button buttonOpenFile_GAE;
        private Button buttonExecute_GAE;
        private Button buttonHelp_GAE;
        private GroupBox groupBoxTask_GAE;
        private TextBox textBoxTask_GAE;
        private Label labelInput_GAE;
        private Label labelInputFileName;
        private TextBox textBoxIn_GAE;
        private Label labelOutput_GAE;
        private TextBox textBoxOut_GAE;
        private OpenFileDialog openFileDialogTask_GAE;
        private ToolTip toolTip_GAE;
    }
}
