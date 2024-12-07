using System.Linq.Expressions;
using Tyuiu.GridinAE.Sprint6.Task2.V22.Lib;

namespace Tyuiu.GridinAE.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new();

        private void buttonExecute_GAE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_GAE.Text);
                int stopStep = Convert.ToInt32(textBoxEndStep_GAE.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                chartFunction_GAE.Titles.Add("График данной функции");
                chartFunction_GAE.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_GAE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len - 1; i++)
                {
                    dataGridViewFunction_GAE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    chartFunction_GAE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-24-2 Гридин Артём Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExecute_GAE_MouseEnter(object sender, EventArgs e)
        {
            buttonExecute_GAE.BackColor = Color.Red;
        }

        private void buttonExecute_GAE_MouseLeave(object sender, EventArgs e)
        {
            buttonExecute_GAE.BackColor = Color.Green;
        }

        private void buttonExecute_GAE_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExecute_GAE.BackColor = Color.Blue;
        }
    }
}
