using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakhovDK.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string pathSavefile = Path.Combine(Convert.ToString(Path.GetTempPath()),"OutPutDataFileTask7V25.txt");
            FileInfo fileinfo = new FileInfo(pathSavefile);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSavefile);
            }
            string input = File.ReadAllText(path);
            string pattern = @"\b[a-zA-Z]+\b";
            string res = Regex.Replace(input, pattern, "");
            res = Regex.Replace(res, @"\s+", " ").Trim();
            res = res.Replace(" .", ".");
            File.AppendAllText(pathSavefile, res);
            return pathSavefile;
        }
    }
}
