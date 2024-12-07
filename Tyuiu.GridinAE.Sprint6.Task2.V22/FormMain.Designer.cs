namespace Tyuiu.GridinAE.Sprint6.Task2.V22
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
            pictureBoxTask_GAE = new PictureBox();
            groupBoxInput_GAE = new GroupBox();
            textBoxEndStep_GAE = new TextBox();
            labelEndStep_GAE = new Label();
            textBoxStartStep_GAE = new TextBox();
            labelStartStep_GAE = new Label();
            buttonExecute_GAE = new Button();
            buttonHelp_GAE = new Button();
            groupBoxOutput_GAE = new GroupBox();
            chartFunction_GAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_GAE = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult_GAE = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GAE).BeginInit();
            groupBoxInput_GAE.SuspendLayout();
            groupBoxOutput_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GAE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Controls.Add(pictureBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(12, 12);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(543, 226);
            groupBoxTask_GAE.TabIndex = 1;
            groupBoxTask_GAE.TabStop = false;
            groupBoxTask_GAE.Text = "Условие";
            // 
            // pictureBoxTask_GAE
            // 
            pictureBoxTask_GAE.Image = (Image)resources.GetObject("pictureBoxTask_GAE.Image");
            pictureBoxTask_GAE.Location = new Point(6, 26);
            pictureBoxTask_GAE.Name = "pictureBoxTask_GAE";
            pictureBoxTask_GAE.Size = new Size(531, 194);
            pictureBoxTask_GAE.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_GAE.TabIndex = 0;
            pictureBoxTask_GAE.TabStop = false;
            // 
            // groupBoxInput_GAE
            // 
            groupBoxInput_GAE.Controls.Add(textBoxEndStep_GAE);
            groupBoxInput_GAE.Controls.Add(labelEndStep_GAE);
            groupBoxInput_GAE.Controls.Add(textBoxStartStep_GAE);
            groupBoxInput_GAE.Controls.Add(labelStartStep_GAE);
            groupBoxInput_GAE.Location = new Point(12, 244);
            groupBoxInput_GAE.Name = "groupBoxInput_GAE";
            groupBoxInput_GAE.Size = new Size(269, 84);
            groupBoxInput_GAE.TabIndex = 2;
            groupBoxInput_GAE.TabStop = false;
            groupBoxInput_GAE.Text = "Ввод данных";
            // 
            // textBoxEndStep_GAE
            // 
            textBoxEndStep_GAE.Location = new Point(137, 46);
            textBoxEndStep_GAE.Name = "textBoxEndStep_GAE";
            textBoxEndStep_GAE.Size = new Size(125, 27);
            textBoxEndStep_GAE.TabIndex = 3;
            // 
            // labelEndStep_GAE
            // 
            labelEndStep_GAE.AutoSize = true;
            labelEndStep_GAE.Location = new Point(137, 23);
            labelEndStep_GAE.Name = "labelEndStep_GAE";
            labelEndStep_GAE.Size = new Size(94, 20);
            labelEndStep_GAE.TabIndex = 2;
            labelEndStep_GAE.Text = "Конец шага:";
            // 
            // textBoxStartStep_GAE
            // 
            textBoxStartStep_GAE.Location = new Point(6, 46);
            textBoxStartStep_GAE.Name = "textBoxStartStep_GAE";
            textBoxStartStep_GAE.Size = new Size(125, 27);
            textBoxStartStep_GAE.TabIndex = 1;
            // 
            // labelStartStep_GAE
            // 
            labelStartStep_GAE.AutoSize = true;
            labelStartStep_GAE.Location = new Point(6, 23);
            labelStartStep_GAE.Name = "labelStartStep_GAE";
            labelStartStep_GAE.Size = new Size(88, 20);
            labelStartStep_GAE.TabIndex = 0;
            labelStartStep_GAE.Text = "Старт шага:";
            // 
            // buttonExecute_GAE
            // 
            buttonExecute_GAE.BackColor = Color.Green;
            buttonExecute_GAE.Location = new Point(414, 255);
            buttonExecute_GAE.Name = "buttonExecute_GAE";
            buttonExecute_GAE.Size = new Size(141, 73);
            buttonExecute_GAE.TabIndex = 5;
            buttonExecute_GAE.Text = "Выполнить";
            buttonExecute_GAE.UseVisualStyleBackColor = false;
            buttonExecute_GAE.Click += buttonExecute_GAE_Click;
            buttonExecute_GAE.MouseDown += buttonExecute_GAE_MouseDown;
            buttonExecute_GAE.MouseEnter += buttonExecute_GAE_MouseEnter;
            buttonExecute_GAE.MouseLeave += buttonExecute_GAE_MouseLeave;
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_GAE.Location = new Point(287, 255);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(121, 73);
            buttonHelp_GAE.TabIndex = 4;
            buttonHelp_GAE.Text = "Справка";
            buttonHelp_GAE.UseVisualStyleBackColor = false;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // groupBoxOutput_GAE
            // 
            groupBoxOutput_GAE.Controls.Add(chartFunction_GAE);
            groupBoxOutput_GAE.Controls.Add(dataGridViewFunction_GAE);
            groupBoxOutput_GAE.Controls.Add(labelResult_GAE);
            groupBoxOutput_GAE.Location = new Point(561, 12);
            groupBoxOutput_GAE.Name = "groupBoxOutput_GAE";
            groupBoxOutput_GAE.Size = new Size(581, 316);
            groupBoxOutput_GAE.TabIndex = 6;
            groupBoxOutput_GAE.TabStop = false;
            groupBoxOutput_GAE.Text = "Вывод данных";
            // 
            // chartFunction_GAE
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_GAE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_GAE.Legends.Add(legend1);
            chartFunction_GAE.Location = new Point(143, 22);
            chartFunction_GAE.Name = "chartFunction_GAE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_GAE.Series.Add(series1);
            chartFunction_GAE.Size = new Size(432, 283);
            chartFunction_GAE.TabIndex = 2;
            chartFunction_GAE.Text = "chart1";
            // 
            // dataGridViewFunction_GAE
            // 
            dataGridViewFunction_GAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_GAE.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_GAE.Location = new Point(6, 49);
            dataGridViewFunction_GAE.Name = "dataGridViewFunction_GAE";
            dataGridViewFunction_GAE.RowHeadersVisible = false;
            dataGridViewFunction_GAE.RowHeadersWidth = 51;
            dataGridViewFunction_GAE.Size = new Size(131, 256);
            dataGridViewFunction_GAE.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
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
            ClientSize = new Size(1154, 336);
            Controls.Add(groupBoxOutput_GAE);
            Controls.Add(buttonExecute_GAE);
            Controls.Add(buttonHelp_GAE);
            Controls.Add(groupBoxInput_GAE);
            Controls.Add(groupBoxTask_GAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 22 | Гридин А. Е.";
            groupBoxTask_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GAE).EndInit();
            groupBoxInput_GAE.ResumeLayout(false);
            groupBoxInput_GAE.PerformLayout();
            groupBoxOutput_GAE.ResumeLayout(false);
            groupBoxOutput_GAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GAE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_GAE;
        private PictureBox pictureBoxTask_GAE;
        private GroupBox groupBoxInput_GAE;
        private TextBox textBoxEndStep_GAE;
        private Label labelEndStep_GAE;
        private TextBox textBoxStartStep_GAE;
        private Label labelStartStep_GAE;
        private Button buttonExecute_GAE;
        private Button buttonHelp_GAE;
        private GroupBox groupBoxOutput_GAE;
        private DataGridView dataGridViewFunction_GAE;
        private Label labelResult_GAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GAE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
