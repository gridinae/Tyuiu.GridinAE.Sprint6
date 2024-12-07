namespace Tyuiu.GridinAE.Sprint6.Task1.V25.Lib;

using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task1V25
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        static double F(int x)
        {
            double divisor = Math.Sin(x) - 2;
            if (divisor == 0)
                return 0;
            else
                return (5 * x + 2.5) / divisor + 2;
        }

        var ret = new double[stopValue - startValue + 1];
        for (int i = 0; i <= stopValue - startValue; i++)
        {
            ret[i] = Math.Round(F(i + startValue), 3);
        }

        return ret;
    }
}
