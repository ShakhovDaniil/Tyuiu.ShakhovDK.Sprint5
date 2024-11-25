using Tyuiu.ShakhovDK.Sprint5.Task0.V27.Lib;
DataService ds = new DataService();
int x = 3;
string res = ds.SaveToFileTextData(x);
Console.Title = "Спринт #4 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #4                                                                              *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                       *");
Console.WriteLine("* Задание #7                                                                             *");
Console.WriteLine("* Вариант #8                                                                             *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дано выражение вычислить его значение при x = 3,\n" +
"Результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль.\n" +
"Округлить до трёх знаков после запятой.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("              3x + 1                                                                      ");
Console.WriteLine("y(x) = (x - 1)                                                                            ");
Console.WriteLine("******************************************************************************************");
Console.WriteLine($"Файл\n {res}\nСоздан");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine(File.ReadAllText(res));
Console.WriteLine("******************************************************************************************");
Console.ReadKey();