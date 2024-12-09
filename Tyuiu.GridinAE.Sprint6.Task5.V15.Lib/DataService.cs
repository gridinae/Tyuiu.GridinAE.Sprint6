namespace Tyuiu.GridinAE.Sprint6.Task5.V15.Lib;

using tyuiu.cources.programming.interfaces.Sprint6;

public class DataService : ISprint6Task5V15
{
    public double[] LoadFromDataFile(string path)
    {
        List<double> l = [];

        using (StreamReader sr = new(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                double value = Convert.ToDouble(line);

                if (value >= 2 && value <= 7)
                {
                    l = l.Append(Math.Round(value, 3)).ToList<double>();
                }
            }
        }
        return l.ToArray();
    }
}
