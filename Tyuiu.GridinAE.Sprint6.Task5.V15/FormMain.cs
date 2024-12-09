namespace Tyuiu.GridinAE.Sprint6.Task5.V15;

using Tyuiu.GridinAE.Sprint6.Task5.V15.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    DataService ds = new();
    string path = @"C:\DataSprint6\InPutDataFileTask5V15.txt";

    private void buttonExecute_GAE_Click(object sender, EventArgs e)
    {
        dataGridViewNums_GAE.ColumnCount = 2;
        dataGridViewNums_GAE.Columns[0].Width = 20;
        dataGridViewNums_GAE.Columns[1].Width = 50;

        chartData_GAE.ChartAreas[0].AxisX.Title = "Ось X";
        chartData_GAE.ChartAreas[0].AxisY.Title = "Ось Y";

        chartData_GAE.Series[0].Points.Clear();

        double[] numsMass = new double[ds.LoadFromDataFile(path).Length];
        numsMass = ds.LoadFromDataFile(path);

        for (int i = 0; i < numsMass.Length; i++)
        {
            dataGridViewNums_GAE.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
            chartData_GAE.Series[0].Points.AddXY(i, numsMass[i]);
        }
    }

    private void buttonOpenFile_GAE_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process txt = new();
        txt.StartInfo.FileName = "notepad.exe";
        txt.StartInfo.Arguments = path;
        txt.Start();
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-24-2 Гридин Артём Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
