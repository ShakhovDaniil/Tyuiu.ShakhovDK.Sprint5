using Tyuiu.ShakhovDK.Sprint5.Task4.V4.Lib;
namespace Tyuiu.ShakhovDK.Sprint5.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "InPutDataFileTask4V4.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool test_res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, test_res);
        }
    }
}
