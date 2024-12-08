namespace Tyuiu.GridinAE.Sprint6.Task3.V15;

using Tyuiu.GridinAE.Sprint6.Task3.V15.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-24-2 Гридин Артём Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void buttonExecute_GAE_Click(object sender, EventArgs e)
    {
        var ds = new DataService();
        var initialMatrix = new int[5, 5]
        {
            { 33, 28, 31, 19, 4 },
            { 1, 32, -3, -17, -12 },
            { 24, -19, 26, 31, -3 },
            { 30, -16, 29, 28, 8 },
            { 30, 5, 11, 7, 32 }
        };
        var sortedMatrix = ds.Calculate(initialMatrix);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                dataGridViewMatrix_GAE.Rows[i].Cells[j].Value = sortedMatrix[i, j].ToString();
            }
        }
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        dataGridViewMatrix_GAE.ColumnCount = 5;
        dataGridViewMatrix_GAE.RowCount = 5;
    }
}
