namespace Tyuiu.GridinAE.Sprint6.Task2.V22.Lib;

using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task2V22
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        static double F(int x)
        {
            double divisor = Math.Cos(x) + x;
            if (divisor == 0)
                return 0;
            else
                return (2 * x - 3) / divisor + 5;
        }

        var ret = new double[stopValue - startValue + 1];
        for (int i = 0; i <= stopValue - startValue; i++)
        {
            ret[i] = Math.Round(F(i + startValue), 2);
        }

        return ret;
    }
}
