using Tyuiu.ShakhovDK.Sprint5.Task1.V5.Lib;
namespace Tyuiu.ShakhovDK.Sprint5.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool test_res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, test_res);
        }
    }
}
