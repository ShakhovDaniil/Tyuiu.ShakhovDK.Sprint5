using Tyuiu.ShakhovDK.Sprint5.Task4.V4.Lib;
DataService ds = new DataService();
string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "InPutDataFileTask4V4.txt");
Console.Title = "Спринт #5 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #5                                                                              *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                                                *");
Console.WriteLine("* Задание #4                                                                             *");
Console.WriteLine("* Вариант #4                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt\n" +
    "(Файл взять из архива согласно вашему варианту.\n" +
    "Создать папку вручную С:\\DataSprint5\\ и скопировать в неё файл),\n" +
    "В котором есть вещественное значение Прочитать значение из файла и подставить вместо Х в формуле\n" +
    "Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и\n" +
    "Вернуть полученный результат на консоль.");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("        0.25x                                                                             ");
Console.WriteLine("y(x) = -------                                                                            ");
Console.WriteLine("       cos(x)                                                                             ");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine(ds.LoadFromDataFile(path));
Console.WriteLine("******************************************************************************************");
Console.ReadKey();
