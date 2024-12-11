using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GridinAE.Sprint6.Task7.V3.Lib;

public class DataService : ISprint6Task7V3
{
    public int[,] GetMatrix(string path)
    {
        string filePath = path;
        string fileData = File.ReadAllText(filePath);

        fileData = fileData.Replace('\n', '\r');
        string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int rows = lines.Length;
        int columns = lines[0].Split(';').Length;

        int[,] arrayValues = new int[rows, columns];

        for (int r = 0; r < rows; r++)
        {
            string[] line_r = lines[r].Split(';');
            for (int c = 0; c < columns; c++)
            {
                arrayValues[r, c] = Convert.ToInt32(line_r[c]);
            }
        }

        return GetMatrix(arrayValues);
    }

    public int[,] GetMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, 0] % 2 == 0)
                matrix[i, 0] = -1;
        }
        return matrix;
    }
}
