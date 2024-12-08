namespace Tyuiu.GridinAE.Sprint6.Task4.V16.Test;

using Tyuiu.GridinAE.Sprint6.Task4.V16.Lib;

[TestClass]
public class DataSerivceTest
{
    [TestMethod]
    public void TestGetMassFunction()
    {
        Assert.AreEqual(62.72, new DataService().GetMassFunction(-60, 60)[32]);
    }
}