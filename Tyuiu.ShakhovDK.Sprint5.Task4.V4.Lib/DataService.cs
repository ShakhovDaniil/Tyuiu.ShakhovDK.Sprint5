using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakhovDK.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            double y =  Math.Round(0.25 * Convert.ToDouble(x) / Math.Cos(Convert.ToDouble(x)), 3);
            return y;
        }
    }
}
