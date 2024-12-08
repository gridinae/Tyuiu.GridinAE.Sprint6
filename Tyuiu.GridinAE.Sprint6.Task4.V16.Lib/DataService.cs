namespace Tyuiu.GridinAE.Sprint6.Task4.V16.Lib;

using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task4V16
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        static double F(int x)
        {
            double divisor = x - 0.4;
            if (divisor == 0)
                return 0;
            return Math.Cos(x) / divisor + Math.Sin(x) * 8 * x + 2;
        }

        var ret = new double[stopValue - startValue + 1];
        for (int i = 0; i <= stopValue - startValue; i++)
        {
            ret[i] = Math.Round(F(i + startValue), 2);
        }

        return ret;
    }
}
