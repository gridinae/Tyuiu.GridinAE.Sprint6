namespace Tyuiu.GridinAE.Sprint6.Task2.V22.Test;

using Tyuiu.GridinAE.Sprint6.Task2.V22.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestGetMassFunction()
    {
        Assert.AreEqual(4.35, new DataService().GetMassFunction(-4, 4)[5]);
    }
}