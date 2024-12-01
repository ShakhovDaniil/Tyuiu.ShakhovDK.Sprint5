using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakhovDK.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            string[] f_array = data.Split(' ');
            double res = 0;
            for (int i = 0; i < f_array.Length; i++)
            {
                f_array[i] = f_array[i].Replace(".", ",");
            }
            foreach (string s in f_array)
            {
                try
                {
                    if (int.Parse(s) > res)
                    {
                        res = int.Parse(s);
                    }
                }
                catch (System.FormatException)
                {
                    continue;
                }
            }
            return res;
        }
    }
}
