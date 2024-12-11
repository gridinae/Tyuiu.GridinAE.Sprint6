using Tyuiu.GridinAE.Sprint6.Task7.V3.Lib;

namespace Tyuiu.GridinAE.Sprint6.Task7.V3.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestGetMatrix()
    {
        var ds = new DataService();
        var path = @"C:\Users\user\source\repos\Tyuiu.GridinAE.Sprint6\Tyuiu.GridinAE.Sprint6.Task7.V3.Test\InPutDataFileTask7V3.csv";
        Assert.AreEqual(-10, ds.GetMatrix(path)[1, 1]);
    }
}