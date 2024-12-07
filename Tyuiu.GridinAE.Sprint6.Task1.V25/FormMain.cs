using Tyuiu.GridinAE.Sprint6.Task1.V25.Lib;

namespace Tyuiu.GridinAE.Sprint6.Task1.V25
{
    public partial class Form1 : Form
    {
        public Form1()
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_GAE.Text = "";
                textBoxResult_GAE.AppendText("+-----------+-----------+\n");
                textBoxResult_GAE.AppendText("|     X     |    f(x)   |\n");
                textBoxResult_GAE.AppendText("+-----------+-----------+\n");

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |   {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_GAE.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_GAE.AppendText("+-----------+-----------+\n");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-24-2 Гридин Артём Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
