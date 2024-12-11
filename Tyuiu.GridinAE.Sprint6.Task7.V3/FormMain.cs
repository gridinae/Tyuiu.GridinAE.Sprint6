namespace Tyuiu.GridinAE.Sprint6.Task7.V3;

using System.IO;
using Tyuiu.GridinAE.Sprint6.Task6.V28;
using Tyuiu.GridinAE.Sprint6.Task7.V3.Lib;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();

        openFileDialogTask_GAE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        saveFileDialogMatrix_GAE.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
    }

    static string openFilePath;
    static int columns;
    static int rows;

    DataService ds = new();

    public static int[,] LoadFromFileData(string filePath)
    {
        string fileData = File.ReadAllText(filePath);

        fileData = fileData.Replace('\n', '\r');
        string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

        rows = lines.Length;
        columns = lines[0].Split(';').Length;

        int[,] arrayValues = new int[rows, columns];

        for (int r = 0; r < rows; r++)
        {
            string[] line_r = lines[r].Split(';');
            for (int c = 0; c < columns; c++)
            {
                arrayValues[r, c] = Convert.ToInt32(line_r[c]);
            }
        }

        return arrayValues;
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
        dataGridViewInMatrix_GAE.ColumnCount = 50;
        dataGridViewOutMatrix_GAE.ColumnCount = 50;
        dataGridViewInMatrix_GAE.RowCount = 50;
        dataGridViewOutMatrix_GAE.RowCount = 50;


        panelInput_GAE.Width = Width / 2;
        panelOutput_GAE.Width = Width / 2;
    }

    private void buttonOpen_GAE_Click(object sender, EventArgs e)
    {
        openFileDialogTask_GAE.ShowDialog();
        openFilePath = openFileDialogTask_GAE.FileName;

        int[,] arrayValues = new int[rows, columns];

        arrayValues = LoadFromFileData(openFilePath);

        dataGridViewInMatrix_GAE.ColumnCount = columns;
        dataGridViewInMatrix_GAE.RowCount = rows;
        dataGridViewOutMatrix_GAE.ColumnCount = columns;
        dataGridViewOutMatrix_GAE.RowCount = rows;

        for (int i = 0; i < columns; i++)
        {
            dataGridViewInMatrix_GAE.Columns[i].Width = 35;
            dataGridViewOutMatrix_GAE.Columns[i].Width = 35;
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                dataGridViewInMatrix_GAE.Rows[r].Cells[c].Value = arrayValues[r, c];
            }
        }

        arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
        buttonExecute_GAE.Enabled = true;
    }

    private void buttonExecute_GAE_Click(object sender, EventArgs e)
    {
        int[,] arrayValues = new int[rows, columns];
        arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                dataGridViewOutMatrix_GAE.Rows[r].Cells[c].Value = arrayValues[r, c];
            }
        }

        buttonSave_GAE.Enabled = true;
    }

    private void buttonSave_GAE_Click(object sender, EventArgs e)
    {
        saveFileDialogMatrix_GAE.FileName = "InPutDataFileTask7V3.csv";
        saveFileDialogMatrix_GAE.InitialDirectory = Directory.GetCurrentDirectory();
        saveFileDialogMatrix_GAE.ShowDialog();

        string path = saveFileDialogMatrix_GAE.FileName;
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;

        if (fileExists)
        {
            File.Delete(path);
        }

        int rows = dataGridViewOutMatrix_GAE.RowCount; // количество строк
        int columns = dataGridViewOutMatrix_GAE.ColumnCount; // количество столбцов

        string str = "";

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j == columns - 1)
                {
                    str += dataGridViewOutMatrix_GAE.Rows[i].Cells[j].Value + ";";
                }
                else
                {
                    str += dataGridViewOutMatrix_GAE.Rows[i].Cells[j].Value;
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }
    }

    private void buttonHelp_GAE_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new();
        formAbout.ShowDialog();
    }
}
