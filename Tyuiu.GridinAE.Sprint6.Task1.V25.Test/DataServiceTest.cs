namespace Tyuiu.GridinAE.Sprint6.Task1.V25.Test;

using Tyuiu.GridinAE.Sprint6.Task1.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestGetMassFunction()
    {
        var ds = new DataService();
        Assert.AreEqual(-6.162 ds.GetMassFunction(-10, 10)[4]);
    }
}