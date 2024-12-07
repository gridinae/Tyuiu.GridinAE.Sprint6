namespace Tyuiu.GridinAE.Sprint6.Task1.V25
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
            groupBoxTask_GAE = new GroupBox();
            pictureBoxTask_GAE = new PictureBox();
            groupBoxInput_GAE = new GroupBox();
            textBoxEndStep_GAE = new TextBox();
            labelEndStep_GAE = new Label();
            textBoxStartStep_GAE = new TextBox();
            labelStartStep_GAE = new Label();
            buttonHelp_GAE = new Button();
            buttonExecute_GAE = new Button();
            groupBoxOutput_GAE = new GroupBox();
            textBoxResult_GAE = new TextBox();
            labelResult_GAE = new Label();
            groupBoxTask_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GAE).BeginInit();
            groupBoxInput_GAE.SuspendLayout();
            groupBoxOutput_GAE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Controls.Add(pictureBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(12, 12);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(543, 226);
            groupBoxTask_GAE.TabIndex = 0;
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
            groupBoxInput_GAE.TabIndex = 1;
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
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_GAE.Location = new Point(287, 255);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(121, 73);
            buttonHelp_GAE.TabIndex = 2;
            buttonHelp_GAE.Text = "Справка";
            buttonHelp_GAE.UseVisualStyleBackColor = false;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // buttonExecute_GAE
            // 
            buttonExecute_GAE.BackColor = Color.FromArgb(192, 0, 0);
            buttonExecute_GAE.Location = new Point(414, 255);
            buttonExecute_GAE.Name = "buttonExecute_GAE";
            buttonExecute_GAE.Size = new Size(141, 73);
            buttonExecute_GAE.TabIndex = 3;
            buttonExecute_GAE.Text = "Выполнить";
            buttonExecute_GAE.UseVisualStyleBackColor = false;
            buttonExecute_GAE.Click += buttonExecute_GAE_Click;
            // 
            // groupBoxOutput_GAE
            // 
            groupBoxOutput_GAE.Controls.Add(textBoxResult_GAE);
            groupBoxOutput_GAE.Controls.Add(labelResult_GAE);
            groupBoxOutput_GAE.Location = new Point(561, 12);
            groupBoxOutput_GAE.Name = "groupBoxOutput_GAE";
            groupBoxOutput_GAE.Size = new Size(273, 316);
            groupBoxOutput_GAE.TabIndex = 4;
            groupBoxOutput_GAE.TabStop = false;
            groupBoxOutput_GAE.Text = "Вывод данных";
            // 
            // textBoxResult_GAE
            // 
            textBoxResult_GAE.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_GAE.Location = new Point(6, 49);
            textBoxResult_GAE.Multiline = true;
            textBoxResult_GAE.Name = "textBoxResult_GAE";
            textBoxResult_GAE.ReadOnly = true;
            textBoxResult_GAE.ScrollBars = ScrollBars.Vertical;
            textBoxResult_GAE.Size = new Size(261, 261);
            textBoxResult_GAE.TabIndex = 1;
            textBoxResult_GAE.WordWrap = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 340);
            Controls.Add(groupBoxOutput_GAE);
            Controls.Add(buttonExecute_GAE);
            Controls.Add(buttonHelp_GAE);
            Controls.Add(groupBoxInput_GAE);
            Controls.Add(groupBoxTask_GAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 25 | Гридин А. Е.";
            Load += Form1_Load;
            groupBoxTask_GAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GAE).EndInit();
            groupBoxInput_GAE.ResumeLayout(false);
            groupBoxInput_GAE.PerformLayout();
            groupBoxOutput_GAE.ResumeLayout(false);
            groupBoxOutput_GAE.PerformLayout();
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
        private Button buttonHelp_GAE;
        private Button buttonExecute_GAE;
        private GroupBox groupBoxOutput_GAE;
        private TextBox textBoxResult_GAE;
        private Label labelResult_GAE;
    }
}
