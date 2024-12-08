namespace Tyuiu.GridinAE.Sprint6.Task4.V16;

using Tyuiu.GridinAE.Sprint6.Task4.V16.Lib;

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

            chartFunction_GAE.ChartAreas[0].AxisX.Title = "��� X";
            chartFunction_GAE.ChartAreas[0].AxisY.Title = "��� Y";

            textBoxOutput_GAE.Text = "";

            chartFunction_GAE.Series[0].Points.Clear();
            for (int i = 0; i <= len - 1; i++)
            {
                chartFunction_GAE.Series[0].Points.AddXY(startStep, valueArray[i]);
                textBoxOutput_GAE.AppendText(valueArray[i] + "\n");
                startStep++;
            }

        }
        catch
        {
            MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonSave_GAE_Click(object sender, EventArgs e)
    {
        try
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V16.txt";
            File.WriteAllText(path, textBoxOutput_GAE.Text);

            DialogResult dialogResult = MessageBox.Show($"���� {path} ������� ��������! ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
        catch
        {
            MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e)
    {
        MessageBox.Show("���� 4 �������� ������� ������ ����-24-2 ������ ���� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
