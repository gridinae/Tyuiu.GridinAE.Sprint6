namespace Tyuiu.GridinAE.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_GAE = new GroupBox();
            textBoxTask_GAE = new TextBox();
            buttonExecute_GAE = new Button();
            buttonOpenFile_GAE = new Button();
            buttonHelp_GAE = new Button();
            groupBoxOutput_GAE = new GroupBox();
            dataGridViewNums_GAE = new DataGridView();
            chartData_GAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_GAE.SuspendLayout();
            groupBoxOutput_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_GAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartData_GAE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Controls.Add(textBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(12, 12);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(418, 88);
            groupBoxTask_GAE.TabIndex = 1;
            groupBoxTask_GAE.TabStop = false;
            groupBoxTask_GAE.Text = "Условие";
            // 
            // textBoxTask_GAE
            // 
            textBoxTask_GAE.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_GAE.Location = new Point(6, 26);
            textBoxTask_GAE.Multiline = true;
            textBoxTask_GAE.Name = "textBoxTask_GAE";
            textBoxTask_GAE.ReadOnly = true;
            textBoxTask_GAE.ScrollBars = ScrollBars.Vertical;
            textBoxTask_GAE.Size = new Size(406, 54);
            textBoxTask_GAE.TabIndex = 0;
            textBoxTask_GAE.Text = resources.GetString("textBoxTask_GAE.Text");
            // 
            // buttonExecute_GAE
            // 
            buttonExecute_GAE.BackColor = Color.SeaGreen;
            buttonExecute_GAE.Location = new Point(436, 12);
            buttonExecute_GAE.Name = "buttonExecute_GAE";
            buttonExecute_GAE.Size = new Size(97, 88);
            buttonExecute_GAE.TabIndex = 5;
            buttonExecute_GAE.Text = "Выполнить";
            buttonExecute_GAE.UseVisualStyleBackColor = false;
            buttonExecute_GAE.Click += buttonExecute_GAE_Click;
            // 
            // buttonOpenFile_GAE
            // 
            buttonOpenFile_GAE.BackColor = Color.DodgerBlue;
            buttonOpenFile_GAE.Location = new Point(539, 12);
            buttonOpenFile_GAE.Name = "buttonOpenFile_GAE";
            buttonOpenFile_GAE.Size = new Size(97, 88);
            buttonOpenFile_GAE.TabIndex = 6;
            buttonOpenFile_GAE.Text = "Открыть файл";
            buttonOpenFile_GAE.UseVisualStyleBackColor = false;
            buttonOpenFile_GAE.Click += buttonOpenFile_GAE_Click;
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAE.BackColor = Color.Aqua;
            buttonHelp_GAE.Location = new Point(691, 12);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(97, 88);
            buttonHelp_GAE.TabIndex = 7;
            buttonHelp_GAE.Text = "Справка";
            buttonHelp_GAE.UseVisualStyleBackColor = false;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // groupBoxOutput_GAE
            // 
            groupBoxOutput_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutput_GAE.Controls.Add(dataGridViewNums_GAE);
            groupBoxOutput_GAE.Location = new Point(12, 106);
            groupBoxOutput_GAE.Name = "groupBoxOutput_GAE";
            groupBoxOutput_GAE.Size = new Size(178, 332);
            groupBoxOutput_GAE.TabIndex = 8;
            groupBoxOutput_GAE.TabStop = false;
            groupBoxOutput_GAE.Text = "Вывод данных";
            // 
            // dataGridViewNums_GAE
            // 
            dataGridViewNums_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewNums_GAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_GAE.ColumnHeadersVisible = false;
            dataGridViewNums_GAE.Location = new Point(6, 26);
            dataGridViewNums_GAE.Name = "dataGridViewNums_GAE";
            dataGridViewNums_GAE.ReadOnly = true;
            dataGridViewNums_GAE.RowHeadersVisible = false;
            dataGridViewNums_GAE.RowHeadersWidth = 51;
            dataGridViewNums_GAE.Size = new Size(166, 300);
            dataGridViewNums_GAE.TabIndex = 0;
            // 
            // chartData_GAE
            // 
            chartData_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartData_GAE.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartData_GAE.Legends.Add(legend1);
            chartData_GAE.Location = new Point(196, 106);
            chartData_GAE.Name = "chartData_GAE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartData_GAE.Series.Add(series1);
            chartData_GAE.Size = new Size(592, 332);
            chartData_GAE.TabIndex = 9;
            chartData_GAE.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartData_GAE);
            Controls.Add(groupBoxOutput_GAE);
            Controls.Add(buttonHelp_GAE);
            Controls.Add(buttonOpenFile_GAE);
            Controls.Add(buttonExecute_GAE);
            Controls.Add(groupBoxTask_GAE);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 15 | Гридин А. Е.";
            groupBoxTask_GAE.ResumeLayout(false);
            groupBoxTask_GAE.PerformLayout();
            groupBoxOutput_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_GAE).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartData_GAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_GAE;
        private TextBox textBoxTask_GAE;
        private Button buttonExecute_GAE;
        private Button buttonOpenFile_GAE;
        private Button buttonHelp_GAE;
        private GroupBox groupBoxOutput_GAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData_GAE;
        private DataGridView dataGridViewNums_GAE;
    }
}
