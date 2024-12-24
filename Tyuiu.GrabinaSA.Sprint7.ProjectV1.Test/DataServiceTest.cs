using Tyuiu.GrabinaSA.Sprint7.ProjectV1.Lib;
namespace Tyuiu.GrabinaSA.Sprint7.ProjectV1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetDataValid()
        {
            DataService ds = new DataService();
            var res = ds.GetData("C:\\Users\\sakur\\Desktop\\test.csv");
            string[,] wait = { { "А555АА777", "Toyota", "Розовый", "700" } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
