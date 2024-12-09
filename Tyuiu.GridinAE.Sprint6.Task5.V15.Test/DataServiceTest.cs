namespace Tyuiu.GridinAE.Sprint6.Task5.V15.Test;

using Tyuiu.GridinAE.Sprint6.Task5.V15.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestLoadFromDataFile()
    {
        var path = @"C:\DataSprint6\InPutDataFileTask5V15.txt";
        Assert.AreEqual(3.36, new DataService().LoadFromDataFile(path)[0]);
    }
}