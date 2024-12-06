namespace Tyuiu.GridinAE.Sprint6.Task0.V24
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
            groupBoxTask_GAE = new GroupBox();
            pictureBoxTask_GAE = new PictureBox();
            textBoxTask_GAE = new TextBox();
            groupBoxInput_GAE = new GroupBox();
            textBoxXInput_GAE = new TextBox();
            labelVarX_GAE = new Label();
            groupBoxOutput_GAE = new GroupBox();
            textBoxResult_GAE = new TextBox();
            labelResult_GAE = new Label();
            buttonDone_GAE = new Button();
            buttonHelp_GAE = new Button();
            groupBoxTask_GAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GAE).BeginInit();
            groupBoxInput_GAE.SuspendLayout();
            groupBoxOutput_GAE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_GAE
            // 
            groupBoxTask_GAE.Controls.Add(pictureBoxTask_GAE);
            groupBoxTask_GAE.Controls.Add(textBoxTask_GAE);
            groupBoxTask_GAE.Location = new Point(12, 12);
            groupBoxTask_GAE.Name = "groupBoxTask_GAE";
            groupBoxTask_GAE.Size = new Size(776, 204);
            groupBoxTask_GAE.TabIndex = 0;
            groupBoxTask_GAE.TabStop = false;
            groupBoxTask_GAE.Text = "Условие";
            // 
            // pictureBoxTask_GAE
            // 
            pictureBoxTask_GAE.Image = Properties.Resources.TaskPicture;
            pictureBoxTask_GAE.Location = new Point(527, 26);
            pictureBoxTask_GAE.Name = "pictureBoxTask_GAE";
            pictureBoxTask_GAE.Size = new Size(243, 62);
            pictureBoxTask_GAE.TabIndex = 1;
            pictureBoxTask_GAE.TabStop = false;
            // 
            // textBoxTask_GAE
            // 
            textBoxTask_GAE.Location = new Point(6, 26);
            textBoxTask_GAE.Multiline = true;
            textBoxTask_GAE.Name = "textBoxTask_GAE";
            textBoxTask_GAE.ReadOnly = true;
            textBoxTask_GAE.Size = new Size(515, 172);
            textBoxTask_GAE.TabIndex = 0;
            textBoxTask_GAE.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // groupBoxInput_GAE
            // 
            groupBoxInput_GAE.Controls.Add(textBoxXInput_GAE);
            groupBoxInput_GAE.Controls.Add(labelVarX_GAE);
            groupBoxInput_GAE.Location = new Point(12, 222);
            groupBoxInput_GAE.Name = "groupBoxInput_GAE";
            groupBoxInput_GAE.Padding = new Padding(16, 80, 80, 16);
            groupBoxInput_GAE.Size = new Size(521, 159);
            groupBoxInput_GAE.TabIndex = 1;
            groupBoxInput_GAE.TabStop = false;
            groupBoxInput_GAE.Text = "Ввод данных";
            // 
            // textBoxXInput_GAE
            // 
            textBoxXInput_GAE.Location = new Point(19, 80);
            textBoxXInput_GAE.Name = "textBoxXInput_GAE";
            textBoxXInput_GAE.Size = new Size(125, 27);
            textBoxXInput_GAE.TabIndex = 1;
            textBoxXInput_GAE.KeyPress += textBoxXInput_GAE_KeyPress;
            // 
            // labelVarX_GAE
            // 
            labelVarX_GAE.AutoSize = true;
            labelVarX_GAE.Location = new Point(19, 57);
            labelVarX_GAE.Name = "labelVarX_GAE";
            labelVarX_GAE.Size = new Size(114, 20);
            labelVarX_GAE.TabIndex = 0;
            labelVarX_GAE.Text = "Переменная X:";
            // 
            // groupBoxOutput_GAE
            // 
            groupBoxOutput_GAE.Controls.Add(textBoxResult_GAE);
            groupBoxOutput_GAE.Controls.Add(labelResult_GAE);
            groupBoxOutput_GAE.Location = new Point(539, 222);
            groupBoxOutput_GAE.Name = "groupBoxOutput_GAE";
            groupBoxOutput_GAE.Size = new Size(250, 159);
            groupBoxOutput_GAE.TabIndex = 2;
            groupBoxOutput_GAE.TabStop = false;
            groupBoxOutput_GAE.Text = "Вывод данных";
            // 
            // textBoxResult_GAE
            // 
            textBoxResult_GAE.Location = new Point(17, 80);
            textBoxResult_GAE.Name = "textBoxResult_GAE";
            textBoxResult_GAE.ReadOnly = true;
            textBoxResult_GAE.Size = new Size(125, 27);
            textBoxResult_GAE.TabIndex = 2;
            // 
            // labelResult_GAE
            // 
            labelResult_GAE.AutoSize = true;
            labelResult_GAE.Location = new Point(17, 57);
            labelResult_GAE.Name = "labelResult_GAE";
            labelResult_GAE.Size = new Size(82, 20);
            labelResult_GAE.TabIndex = 1;
            labelResult_GAE.Text = "Результат: ";
            // 
            // buttonDone_GAE
            // 
            buttonDone_GAE.Location = new Point(619, 390);
            buttonDone_GAE.Name = "buttonDone_GAE";
            buttonDone_GAE.Size = new Size(169, 62);
            buttonDone_GAE.TabIndex = 3;
            buttonDone_GAE.Text = "Выполнить";
            buttonDone_GAE.UseVisualStyleBackColor = true;
            buttonDone_GAE.Click += buttonDone_GAE_Click;
            // 
            // buttonHelp_GAE
            // 
            buttonHelp_GAE.FlatAppearance.BorderColor = Color.Black;
            buttonHelp_GAE.FlatStyle = FlatStyle.Flat;
            buttonHelp_GAE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_GAE.Location = new Point(539, 390);
            buttonHelp_GAE.Name = "buttonHelp_GAE";
            buttonHelp_GAE.Size = new Size(74, 62);
            buttonHelp_GAE.TabIndex = 4;
            buttonHelp_GAE.Text = "?";
            buttonHelp_GAE.UseVisualStyleBackColor = true;
            buttonHelp_GAE.Click += buttonHelp_GAE_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(buttonHelp_GAE);
            Controls.Add(buttonDone_GAE);
            Controls.Add(groupBoxOutput_GAE);
            Controls.Add(groupBoxInput_GAE);
            Controls.Add(groupBoxTask_GAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 24 | Гридин А. Е.";
            groupBoxTask_GAE.ResumeLayout(false);
            groupBoxTask_GAE.PerformLayout();
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
        private TextBox textBoxTask_GAE;
        private GroupBox groupBoxInput_GAE;
        private GroupBox groupBoxOutput_GAE;
        private Label labelVarX_GAE;
        private TextBox textBoxXInput_GAE;
        private Label labelResult_GAE;
        private TextBox textBoxResult_GAE;
        private Button buttonDone_GAE;
        private Button buttonHelp_GAE;
    }
}
