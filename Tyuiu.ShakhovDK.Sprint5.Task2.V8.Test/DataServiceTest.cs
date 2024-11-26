﻿using Tyuiu.ShakhovDK.Sprint5.Task2.V8.Lib;
namespace Tyuiu.ShakhovDK.Sprint5.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool test_res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, test_res);
        }
    }
}