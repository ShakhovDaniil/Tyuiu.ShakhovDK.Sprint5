using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakhovDK.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask3.bin");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y = Math.Round((2 * Math.Pow(x, 2) - 1) / (Math.Pow(Math.Pow(x, 2) - 2, 0.5)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
