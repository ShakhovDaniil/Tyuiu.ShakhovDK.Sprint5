using Tyuiu.ShakhovDK.Sprint5.Task2.V8.Lib;
DataService ds = new DataService();
int[,] matrix = new int[3, 3] { {9, 4, -6 },
                                {3, 9, 9 },
                                {-6, 7, -4 } };
string res = ds.SaveToFileTextData(matrix);
string[] valuearray = File.ReadAllLines(res);
Console.Title = "Спринт #5 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #5                                                                              *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                                *");
Console.WriteLine("* Задание #2                                                                             *");
Console.WriteLine("* Вариант #8                                                                             *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан двумерный целочисленный массив 3 на 3 элементов,\n" +
    "Заполненный значениями с клавиатуры.\n" +
    "Заменить положительные элементы массива на 1, отрицательные на 0.\n" +
    "Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("9; 4; -6\n3; 9; 9\n-6; 7; -4                                                  ");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("Maccив:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("******************************************************************************************");
Console.WriteLine($"Файл\n {res}\nСоздан");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();