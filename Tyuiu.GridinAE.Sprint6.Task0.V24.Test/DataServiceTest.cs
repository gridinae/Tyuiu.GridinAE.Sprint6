namespace Tyuiu.GridinAE.Sprint6.Task0.V24.Test;

using Tyuiu.GridinAE.Sprint6.Task0.V24.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalc()
    {
        var dataService = new DataService();
        Assert.AreEqual(4294967296, dataService.Calculate(5));
    }
}