namespace Tyuiu.GridinAE.Sprint6.Task3.V15.Test;

using Tyuiu.GridinAE.Sprint6.Task3.V15.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        var initialMatrix = new int[3, 3] { { 0, 1, -2}, { 1, -5, -12 }, { 8, -2, 0 } };
        var expectedSortedMatrix = new int[3, 3] { { 0, 1, -12 }, { 1, -5, -2 }, { 8, -2, 0 } };
        CollectionAssert.AreEqual(expectedSortedMatrix, new DataService().Calculate(initialMatrix));
    }
}