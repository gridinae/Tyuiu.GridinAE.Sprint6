namespace Tyuiu.GridinAE.Sprint6.Task0.V24.Lib;

using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task0V24
{
    public double Calculate(int x) => Math.Round(Math.Pow(x - 1, 3 * x + 1), 3);
}
