using Tyuiu.ShakhovDK.Sprint5.Task6.V29.Lib;
namespace Tyuiu.ShakhovDK.Sprint5.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V29.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool test_res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, test_res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V29.txt";
            DataService ds = new DataService();
            int wait = 3;
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}