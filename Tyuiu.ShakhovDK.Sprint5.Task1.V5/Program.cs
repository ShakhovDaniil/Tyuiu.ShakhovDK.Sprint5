using Tyuiu.ShakhovDK.Sprint5.Task1.V5.Lib;
DataService ds = new DataService();
int startvalue = -5;
int endvalue = 5;
string res = ds.SaveToFileTextData(startvalue, endvalue);
string[] valuearray = File.ReadAllLines(res);
Console.Title = "Спринт #5 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #5                                                                              *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                                *");
Console.WriteLine("* Задание #1                                                                             *");
Console.WriteLine("* Вариант #5                                                                             *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дана функция, F(x) = 5 - 3x + 1 + sin(x) 2х - 0,5 (произвести табулирование)\n" +
    "f(x) на заданном диапазоне[-5; 5] с шагом 1\n" +
    "Произвести проверку деления на ноль. При делении на ноль вернуть значение 0.\n" +
    "Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.\n" +
    "Значения округлить до двух знаков после запятой.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("F(x) = 5 - 3x + 1 + sin(x) 2х - 0,5                                                       ");
Console.WriteLine("******************************************************************************************");
Console.WriteLine($"Файл\n {res}\nСоздан");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine("+----------+----------+");
Console.WriteLine("|    X     |    f(x)  |");
Console.WriteLine("+----------+----------+");
int len = Math.Abs(endvalue) + Math.Abs(startvalue);
for (int i = 0; i <= len; i++)
{
    Console.WriteLine("|{0,6:d}    | {1, 7:f2}  |", startvalue, valuearray[i]);
    startvalue++;
}
Console.WriteLine("+----------+----------+");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();