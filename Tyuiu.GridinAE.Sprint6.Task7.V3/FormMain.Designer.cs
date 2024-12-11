namespace Tyuiu.GridinAE.Sprint6.Task7.V3
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
            panelButtons_GAE = new Panel();
            buttonHelp_GAE = new Button();
            buttonSave_GAE = new Button();
            buttonExecute_GAE = new Button();
            buttonOpen_GAE = new Button();
            panelTask_GAE = new Panel();
            groupBoxTask_GAE = new GroupBox();
            textBoxTask_GAE = new TextBox();
            panelInput_GAE = new Panel();
            groupBoxInput_GAE = new GroupBox();
            dataGridViewInMatrix_GAE = new DataGridView();
            splitContainerInOutPanels_GAE = new SplitContainer();
            panelOutput_GAE = new Panel();
            groupBoxOutput_GAE = new GroupBox();
            dataGridViewOutMatrix_GAE = new DataGridView();
            openFileDialogTask_GAE = new OpenFileDialog();
            saveFileDialogMatrix_GAE = new SaveFileDialog();
            panelButtons_GAE.SuspendLayout();
            panelTask_GAE.SuspendLayout();
            groupBoxTask_GAE.SuspendLayout();
            panelInput_GAE.SuspendLayout();
            groupBoxInput_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_GAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPanels_GAE).BeginInit();
            splitContainerInOutPanels_GAE.Panel1.SuspendLayout();
            splitContainerInOutPanels_GAE.Panel2.SuspendLayout();
            splitContainerInOutPanels_GAE.SuspendLayout();
            panelOutput_GAE.SuspendLayout();
            groupBoxOutput_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_GAE).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_GAE
            // 
            panelButtons_GAE.Controls.Add(buttonHelp_GAE);
            panelButtons_GAE.Controls.Add(buttonSave_GAE);
            panelButtons_GAE.Controls.Add(buttonExecute_GAE);
            panelButtons_GAE.Controls.Add(buttonOpen_GAE);
            panelButtons_GAE.Dock = DockStyle.Top;
            panelButtons_GAE.Location = new Point(0, 0);
            panelButtons_GAE.Name = "panelButtons_GAE";
            panelButtons_GAE.Size = new Size(908, 77);
            panelButtons_GAE.TabIndex = 0;
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAE.FlatStyle = FlatStyle.Flat;
            buttonHelp_GAE.Image = (Image)resources.GetObject("buttonHelp_GAE.Image");
            buttonHelp_GAE.Location = new Point(815, 3);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(90, 71);
            buttonHelp_GAE.TabIndex = 3;
            buttonHelp_GAE.UseVisualStyleBackColor = true;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // buttonSave_GAE
            // 
            buttonSave_GAE.Enabled = false;
            buttonSave_GAE.FlatStyle = FlatStyle.Flat;
            buttonSave_GAE.Image = (Image)resources.GetObject("buttonSave_GAE.Image");
            buttonSave_GAE.Location = new Point(195, 3);
            buttonSave_GAE.Name = "buttonSave_GAE";
            buttonSave_GAE.Size = new Size(90, 71);
            buttonSave_GAE.TabIndex = 2;
            buttonSave_GAE.UseVisualStyleBackColor = true;
            buttonSave_GAE.Click += buttonSave_GAE_Click;
            // 
            // buttonExecute_GAE
            // 
            buttonExecute_GAE.Enabled = false;
            buttonExecute_GAE.FlatStyle = FlatStyle.Flat;
            buttonExecute_GAE.Image = (Image)resources.GetObject("buttonExecute_GAE.Image");
            buttonExecute_GAE.Location = new Point(99, 3);
            buttonExecute_GAE.Name = "buttonExecute_GAE";
            buttonExecute_GAE.Size = new Size(90, 71);
            buttonExecute_GAE.TabIndex = 1;
            buttonExecute_GAE.UseVisualStyleBackColor = true;
            buttonExecute_GAE.Click += buttonExecute_GAE_Click;
            // 
            // buttonOpen_GAE
            // 
            buttonOpen_GAE.FlatStyle = FlatStyle.Flat;
            buttonOpen_GAE.Image = (Image)resources.GetObject("buttonOpen_GAE.Image");
            buttonOpen_GAE.Location = new Point(3, 3);
            buttonOpen_GAE.Name = "buttonOpen_GAE";
            buttonOpen_GAE.Size = new Size(90, 71);
            buttonOpen_GAE.TabIndex = 0;
            buttonOpen_GAE.UseVisualStyleBackColor = true;
            buttonOpen_GAE.Click += buttonOpen_GAE_Click;
            // 
            // panelTask_GAE
            // 
            panelTask_GAE.Controls.Add(groupBoxTask_GAE);
            panelTask_GAE.Dock = DockStyle.Top;
            panelTask_GAE.Location = new Point(0, 77);
            panelTask_GAE.Name = "panelTask_GAE";
            panelTask_GAE.Size = new Size(908, 113);
            panelTask_GAE.TabIndex = 1;
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_GAE.Controls.Add(textBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(3, 6);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(902, 101);
            groupBoxTask_GAE.TabIndex = 0;
            groupBoxTask_GAE.TabStop = false;
            groupBoxTask_GAE.Text = "Условие";
            // 
            // textBoxTask_GAE
            // 
            textBoxTask_GAE.Dock = DockStyle.Fill;
            textBoxTask_GAE.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_GAE.Location = new Point(3, 23);
            textBoxTask_GAE.Multiline = true;
            textBoxTask_GAE.Name = "textBoxTask_GAE";
            textBoxTask_GAE.ReadOnly = true;
            textBoxTask_GAE.Size = new Size(896, 75);
            textBoxTask_GAE.TabIndex = 0;
            textBoxTask_GAE.Text = resources.GetString("textBoxTask_GAE.Text");
            // 
            // panelInput_GAE
            // 
            panelInput_GAE.Controls.Add(groupBoxInput_GAE);
            panelInput_GAE.Dock = DockStyle.Fill;
            panelInput_GAE.Location = new Point(0, 0);
            panelInput_GAE.Name = "panelInput_GAE";
            panelInput_GAE.Size = new Size(299, 319);
            panelInput_GAE.TabIndex = 2;
            // 
            // groupBoxInput_GAE
            // 
            groupBoxInput_GAE.Controls.Add(dataGridViewInMatrix_GAE);
            groupBoxInput_GAE.Dock = DockStyle.Fill;
            groupBoxInput_GAE.Location = new Point(0, 0);
            groupBoxInput_GAE.Name = "groupBoxInput_GAE";
            groupBoxInput_GAE.Size = new Size(299, 319);
            groupBoxInput_GAE.TabIndex = 0;
            groupBoxInput_GAE.TabStop = false;
            groupBoxInput_GAE.Text = "Ввод";
            // 
            // dataGridViewInMatrix_GAE
            // 
            dataGridViewInMatrix_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInMatrix_GAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_GAE.ColumnHeadersVisible = false;
            dataGridViewInMatrix_GAE.Location = new Point(3, 23);
            dataGridViewInMatrix_GAE.Name = "dataGridViewInMatrix_GAE";
            dataGridViewInMatrix_GAE.RowHeadersVisible = false;
            dataGridViewInMatrix_GAE.RowHeadersWidth = 51;
            dataGridViewInMatrix_GAE.Size = new Size(293, 293);
            dataGridViewInMatrix_GAE.TabIndex = 0;
            // 
            // splitContainerInOutPanels_GAE
            // 
            splitContainerInOutPanels_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainerInOutPanels_GAE.Location = new Point(0, 190);
            splitContainerInOutPanels_GAE.Name = "splitContainerInOutPanels_GAE";
            // 
            // splitContainerInOutPanels_GAE.Panel1
            // 
            splitContainerInOutPanels_GAE.Panel1.Controls.Add(panelInput_GAE);
            // 
            // splitContainerInOutPanels_GAE.Panel2
            // 
            splitContainerInOutPanels_GAE.Panel2.Controls.Add(panelOutput_GAE);
            splitContainerInOutPanels_GAE.Size = new Size(908, 319);
            splitContainerInOutPanels_GAE.SplitterDistance = 299;
            splitContainerInOutPanels_GAE.TabIndex = 4;
            // 
            // panelOutput_GAE
            // 
            panelOutput_GAE.Controls.Add(groupBoxOutput_GAE);
            panelOutput_GAE.Dock = DockStyle.Fill;
            panelOutput_GAE.Location = new Point(0, 0);
            panelOutput_GAE.Name = "panelOutput_GAE";
            panelOutput_GAE.Size = new Size(605, 319);
            panelOutput_GAE.TabIndex = 3;
            // 
            // groupBoxOutput_GAE
            // 
            groupBoxOutput_GAE.Controls.Add(dataGridViewOutMatrix_GAE);
            groupBoxOutput_GAE.Dock = DockStyle.Fill;
            groupBoxOutput_GAE.Location = new Point(0, 0);
            groupBoxOutput_GAE.Name = "groupBoxOutput_GAE";
            groupBoxOutput_GAE.Size = new Size(605, 319);
            groupBoxOutput_GAE.TabIndex = 1;
            groupBoxOutput_GAE.TabStop = false;
            groupBoxOutput_GAE.Text = "Вывод";
            // 
            // dataGridViewOutMatrix_GAE
            // 
            dataGridViewOutMatrix_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOutMatrix_GAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_GAE.ColumnHeadersVisible = false;
            dataGridViewOutMatrix_GAE.Location = new Point(3, 23);
            dataGridViewOutMatrix_GAE.Name = "dataGridViewOutMatrix_GAE";
            dataGridViewOutMatrix_GAE.RowHeadersVisible = false;
            dataGridViewOutMatrix_GAE.RowHeadersWidth = 29;
            dataGridViewOutMatrix_GAE.Size = new Size(599, 293);
            dataGridViewOutMatrix_GAE.TabIndex = 1;
            // 
            // openFileDialogTask_GAE
            // 
            openFileDialogTask_GAE.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 510);
            Controls.Add(splitContainerInOutPanels_GAE);
            Controls.Add(panelTask_GAE);
            Controls.Add(panelButtons_GAE);
            MinimumSize = new Size(926, 557);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 3 | Гридин А. Е.";
            Load += FormMain_Load;
            panelButtons_GAE.ResumeLayout(false);
            panelTask_GAE.ResumeLayout(false);
            groupBoxTask_GAE.ResumeLayout(false);
            groupBoxTask_GAE.PerformLayout();
            panelInput_GAE.ResumeLayout(false);
            groupBoxInput_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_GAE).EndInit();
            splitContainerInOutPanels_GAE.Panel1.ResumeLayout(false);
            splitContainerInOutPanels_GAE.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerInOutPanels_GAE).EndInit();
            splitContainerInOutPanels_GAE.ResumeLayout(false);
            panelOutput_GAE.ResumeLayout(false);
            groupBoxOutput_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_GAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_GAE;
        private Panel panelTask_GAE;
        private Panel panelInput_GAE;
        private Panel panelOutput_GAE;
        private Button buttonOpen_GAE;
        private Button buttonExecute_GAE;
        private Button buttonSave_GAE;
        private Button buttonHelp_GAE;
        private GroupBox groupBoxTask_GAE;
        private TextBox textBoxTask_GAE;
        private GroupBox groupBoxInput_GAE;
        private GroupBox groupBoxOutput_GAE;
        private DataGridView dataGridViewInMatrix_GAE;
        private DataGridView dataGridViewOutMatrix_GAE;
        private SplitContainer splitContainerInOutPanels_GAE;
        private OpenFileDialog openFileDialogTask_GAE;
        private SaveFileDialog saveFileDialogMatrix_GAE;
    }
}
