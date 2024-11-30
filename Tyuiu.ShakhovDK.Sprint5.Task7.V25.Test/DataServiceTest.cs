using Tyuiu.ShakhovDK.Sprint5.Task7.V25.Lib;
namespace Tyuiu.ShakhovDK.Sprint5.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string pathSavefile = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutDataFileTask7V25.txt");
            FileInfo fileInfo = new FileInfo(pathSavefile);
            bool test_res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, test_res);
        }
    }
}
