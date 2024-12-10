namespace Tyuiu.GridinAE.Sprint6.Task6.V28.Test;

using Tyuiu.GridinAE.Sprint6.Task6.V28.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCollectTextFromFile()
    {
        var dataService = new DataService();
        var path = @"C:\Users\user\Desktop\InPutDataFileTask6V28.txt";
        Assert.AreEqual("wFrlYaZtHI", dataService.CollectTextFromFile(path).Split(' ')[1]);
    }
}