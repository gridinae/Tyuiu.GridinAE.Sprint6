namespace Tyuiu.GridinAE.Sprint6.Task4.V16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonHelp_GAE = new Button();
            labelOutput_GAE = new Label();
            textBoxOutput_GAE = new TextBox();
            chartFunction_GAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave_GAE = new Button();
            buttonExecute_GAE = new Button();
            groupBoxInput_GAE = new GroupBox();
            labelStartStep_GAE = new Label();
            textBoxStartStep_GAE = new TextBox();
            labelEndStep_GAE = new Label();
            textBoxEndStep_GAE = new TextBox();
            groupBoxTask_GAE = new GroupBox();
            pictureBoxTask_GAE = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GAE).BeginInit();
            groupBoxInput_GAE.SuspendLayout();
            groupBoxTask_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GAE).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_GAE.BackColor = Color.Aqua;
            buttonHelp_GAE.Location = new Point(932, 12);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(97, 80);
            buttonHelp_GAE.TabIndex = 6;
            buttonHelp_GAE.Text = "Справка";
            buttonHelp_GAE.UseVisualStyleBackColor = false;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // labelOutput_GAE
            // 
            labelOutput_GAE.AutoSize = true;
            labelOutput_GAE.Location = new Point(18, 171);
            labelOutput_GAE.Name = "labelOutput_GAE";
            labelOutput_GAE.Size = new Size(57, 20);
            labelOutput_GAE.TabIndex = 4;
            labelOutput_GAE.Text = "Вывод:";
            // 
            // textBoxOutput_GAE
            // 
            textBoxOutput_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxOutput_GAE.Location = new Point(12, 194);
            textBoxOutput_GAE.Multiline = true;
            textBoxOutput_GAE.Name = "textBoxOutput_GAE";
            textBoxOutput_GAE.ReadOnly = true;
            textBoxOutput_GAE.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_GAE.Size = new Size(418, 345);
            textBoxOutput_GAE.TabIndex = 7;
            textBoxOutput_GAE.WordWrap = false;
            // 
            // chartFunction_GAE
            // 
            chartFunction_GAE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunction_GAE.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_GAE.Legends.Add(legend1);
            chartFunction_GAE.Location = new Point(436, 98);
            chartFunction_GAE.Name = "chartFunction_GAE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_GAE.Series.Add(series1);
            chartFunction_GAE.Size = new Size(593, 441);
            chartFunction_GAE.TabIndex = 8;
            chartFunction_GAE.Text = "График заданной функции";
            // 
            // buttonSave_GAE
            // 
            buttonSave_GAE.BackColor = Color.DodgerBlue;
            buttonSave_GAE.Location = new Point(814, 12);
            buttonSave_GAE.Name = "buttonSave_GAE";
            buttonSave_GAE.Size = new Size(97, 80);
            buttonSave_GAE.TabIndex = 5;
            buttonSave_GAE.Text = "Сохранить";
            buttonSave_GAE.UseVisualStyleBackColor = false;
            buttonSave_GAE.Click += buttonSave_GAE_Click;
            // 
            // buttonExecute_GAE
            // 
            buttonExecute_GAE.BackColor = Color.SeaGreen;
            buttonExecute_GAE.Location = new Point(711, 12);
            buttonExecute_GAE.Name = "buttonExecute_GAE";
            buttonExecute_GAE.Size = new Size(97, 80);
            buttonExecute_GAE.TabIndex = 4;
            buttonExecute_GAE.Text = "Выполнить";
            buttonExecute_GAE.UseVisualStyleBackColor = false;
            buttonExecute_GAE.Click += buttonExecute_GAE_Click;
            // 
            // groupBoxInput_GAE
            // 
            groupBoxInput_GAE.Controls.Add(textBoxEndStep_GAE);
            groupBoxInput_GAE.Controls.Add(labelEndStep_GAE);
            groupBoxInput_GAE.Controls.Add(textBoxStartStep_GAE);
            groupBoxInput_GAE.Controls.Add(labelStartStep_GAE);
            groupBoxInput_GAE.Location = new Point(436, 12);
            groupBoxInput_GAE.Name = "groupBoxInput_GAE";
            groupBoxInput_GAE.Size = new Size(269, 80);
            groupBoxInput_GAE.TabIndex = 3;
            groupBoxInput_GAE.TabStop = false;
            groupBoxInput_GAE.Text = "Ввод данных";
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
            // textBoxStartStep_GAE
            // 
            textBoxStartStep_GAE.Location = new Point(6, 46);
            textBoxStartStep_GAE.Name = "textBoxStartStep_GAE";
            textBoxStartStep_GAE.Size = new Size(125, 27);
            textBoxStartStep_GAE.TabIndex = 1;
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
            // textBoxEndStep_GAE
            // 
            textBoxEndStep_GAE.Location = new Point(137, 46);
            textBoxEndStep_GAE.Name = "textBoxEndStep_GAE";
            textBoxEndStep_GAE.Size = new Size(125, 27);
            textBoxEndStep_GAE.TabIndex = 3;
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Controls.Add(pictureBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(12, 12);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(418, 156);
            groupBoxTask_GAE.TabIndex = 0;
            groupBoxTask_GAE.TabStop = false;
            groupBoxTask_GAE.Text = "Условие";
            // 
            // pictureBoxTask_GAE
            // 
            pictureBoxTask_GAE.Image = (Image)resources.GetObject("pictureBoxTask_GAE.Image");
            pictureBoxTask_GAE.Location = new Point(6, 26);
            pictureBoxTask_GAE.Name = "pictureBoxTask_GAE";
            pictureBoxTask_GAE.Size = new Size(406, 124);
            pictureBoxTask_GAE.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTask_GAE.TabIndex = 0;
            pictureBoxTask_GAE.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 551);
            Controls.Add(chartFunction_GAE);
            Controls.Add(textBoxOutput_GAE);
            Controls.Add(labelOutput_GAE);
            Controls.Add(buttonHelp_GAE);
            Controls.Add(buttonSave_GAE);
            Controls.Add(buttonExecute_GAE);
            Controls.Add(groupBoxInput_GAE);
            Controls.Add(groupBoxTask_GAE);
            MinimumSize = new Size(1059, 497);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 16 | Гридин А. Е.";
            ((System.ComponentModel.ISupportInitialize)chartFunction_GAE).EndInit();
            groupBoxInput_GAE.ResumeLayout(false);
            groupBoxInput_GAE.PerformLayout();
            groupBoxTask_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonHelp_GAE;
        private Label labelOutput_GAE;
        private TextBox textBoxOutput_GAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GAE;
        private Button buttonSave_GAE;
        private Button buttonExecute_GAE;
        private GroupBox groupBoxInput_GAE;
        private TextBox textBoxEndStep_GAE;
        private Label labelEndStep_GAE;
        private TextBox textBoxStartStep_GAE;
        private Label labelStartStep_GAE;
        private GroupBox groupBoxTask_GAE;
        private PictureBox pictureBoxTask_GAE;
    }
}
