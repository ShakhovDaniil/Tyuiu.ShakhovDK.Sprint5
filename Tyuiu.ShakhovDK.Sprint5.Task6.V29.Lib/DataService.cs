using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakhovDK.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            string[] f_array = data.Split(' ');
            int res = 0;
            foreach (string s in f_array)
            {
                if (s.Length == 7)
                {
                    res++;
                }
            }
            return res;
        }
    }
}