using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GridinAE.Sprint6.Task7.V3.Lib;

public class DataService : ISprint6Task7V3
{
    public int[,] GetMatrix(string path)
    {
        throw new NotImplementedException();
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
