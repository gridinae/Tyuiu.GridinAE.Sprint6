namespace Tyuiu.GridinAE.Sprint6.Task3.V15
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
            groupBoxTask_GAE = new GroupBox();
            textBoxTask_GAE = new TextBox();
            groupBoxOutput_GAE = new GroupBox();
            buttonHelp_GAE = new Button();
            buttonExecute_GAE = new Button();
            dataGridViewMatrix_GAE = new DataGridView();
            labelResult_GAE = new Label();
            groupBoxTask_GAE.SuspendLayout();
            groupBoxOutput_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GAE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Controls.Add(textBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(12, 12);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(543, 378);
            groupBoxTask_GAE.TabIndex = 2;
            groupBoxTask_GAE.TabStop = false;
            groupBoxTask_GAE.Text = "Условие";
            // 
            // textBoxTask_GAE
            // 
            textBoxTask_GAE.Location = new Point(6, 26);
            textBoxTask_GAE.Multiline = true;
            textBoxTask_GAE.Name = "textBoxTask_GAE";
            textBoxTask_GAE.ReadOnly = true;
            textBoxTask_GAE.Size = new Size(531, 346);
            textBoxTask_GAE.TabIndex = 0;
            textBoxTask_GAE.Text = resources.GetString("textBoxTask_GAE.Text");
            // 
            // groupBoxOutput_GAE
            // 
            groupBoxOutput_GAE.Controls.Add(buttonHelp_GAE);
            groupBoxOutput_GAE.Controls.Add(buttonExecute_GAE);
            groupBoxOutput_GAE.Controls.Add(dataGridViewMatrix_GAE);
            groupBoxOutput_GAE.Controls.Add(labelResult_GAE);
            groupBoxOutput_GAE.Location = new Point(561, 12);
            groupBoxOutput_GAE.Name = "groupBoxOutput_GAE";
            groupBoxOutput_GAE.Size = new Size(303, 378);
            groupBoxOutput_GAE.TabIndex = 7;
            groupBoxOutput_GAE.TabStop = false;
            groupBoxOutput_GAE.Text = "Вывод данных";
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.Location = new Point(150, 343);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(29, 29);
            buttonHelp_GAE.TabIndex = 3;
            buttonHelp_GAE.Text = "?";
            buttonHelp_GAE.UseVisualStyleBackColor = true;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // buttonExecute_GAE
            // 
            buttonExecute_GAE.Location = new Point(185, 343);
            buttonExecute_GAE.Name = "buttonExecute_GAE";
            buttonExecute_GAE.Size = new Size(112, 29);
            buttonExecute_GAE.TabIndex = 2;
            buttonExecute_GAE.Text = "Выполнить";
            buttonExecute_GAE.UseVisualStyleBackColor = true;
            buttonExecute_GAE.Click += buttonExecute_GAE_Click;
            // 
            // dataGridViewMatrix_GAE
            // 
            dataGridViewMatrix_GAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix_GAE.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewMatrix_GAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_GAE.ColumnHeadersVisible = false;
            dataGridViewMatrix_GAE.Location = new Point(6, 49);
            dataGridViewMatrix_GAE.Name = "dataGridViewMatrix_GAE";
            dataGridViewMatrix_GAE.RowHeadersVisible = false;
            dataGridViewMatrix_GAE.RowHeadersWidth = 20;
            dataGridViewMatrix_GAE.Size = new Size(291, 288);
            dataGridViewMatrix_GAE.TabIndex = 1;
            // 
            // labelResult_GAE
            // 
            labelResult_GAE.AutoSize = true;
            labelResult_GAE.Location = new Point(6, 26);
            labelResult_GAE.Name = "labelResult_GAE";
            labelResult_GAE.Size = new Size(78, 20);
            labelResult_GAE.TabIndex = 0;
            labelResult_GAE.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 402);
            Controls.Add(groupBoxOutput_GAE);
            Controls.Add(groupBoxTask_GAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 15 | Гридин А. Е.";
            Load += FormMain_Load;
            groupBoxTask_GAE.ResumeLayout(false);
            groupBoxTask_GAE.PerformLayout();
            groupBoxOutput_GAE.ResumeLayout(false);
            groupBoxOutput_GAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_GAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_GAE;
        private TextBox textBoxTask_GAE;
        private GroupBox groupBoxOutput_GAE;
        private Button buttonHelp_GAE;
        private Button buttonExecute_GAE;
        private DataGridView dataGridViewMatrix_GAE;
        private Label labelResult_GAE;
    }
}
