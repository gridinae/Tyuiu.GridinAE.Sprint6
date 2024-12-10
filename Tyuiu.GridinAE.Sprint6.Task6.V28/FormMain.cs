namespace Tyuiu.GridinAE.Sprint6.Task6.V28;

using Tyuiu.GridinAE.Sprint6.Task6.V28.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    string openFilePath;
    DataService ds = new DataService();

    private void buttonOpenFile_GAE_Click(object sender, EventArgs e)
    {
        openFileDialogTask_GAE.ShowDialog();
        openFilePath = openFileDialogTask_GAE.FileName;
        textBoxIn_GAE.Text = File.ReadAllText(openFilePath);
        labelInputFileName.Text = openFilePath;
        buttonExecute_GAE.Enabled = true;
    }

    private void buttonExecute_GAE_Click(object sender, EventArgs e)
    {
        textBoxOut_GAE.Text = ds.CollectTextFromFile(openFilePath);
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new();
        formAbout.ShowDialog();
    }
}
