namespace Tyuiu.GridinAE.Sprint6.Task0.V24;

using Tyuiu.GridinAE.Sprint6.Task0.V24.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonDone_GAE_Click(object sender, EventArgs e)
    {
        DataService ds = new();
        try
        {
            textBoxResult_GAE.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxXInput_GAE.Text)));
        }
        catch
        {
            MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxXInput_GAE_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
        {
            e.Handled = true;
        }
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e)
    {
        MessageBox.Show("���� 0 �������� ������� ������ ����-24-2 ������ ���� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
