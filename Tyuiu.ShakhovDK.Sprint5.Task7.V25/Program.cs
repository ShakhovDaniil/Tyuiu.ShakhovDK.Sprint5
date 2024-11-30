using Tyuiu.ShakhovDK.Sprint5.Task7.V25.Lib;
DataService ds = new DataService();
string path = @"C:\DataSprint5\InPutDataFileTask7V25.txt";
string pathSavefile = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutDataFileTask7V25.txt");
string res = ds.LoadDataAndSave(path);
Console.Title = "Спринт #5 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #5                                                                              *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                *");
Console.WriteLine("* Задание #7                                                                             *");
Console.WriteLine("* Вариант #25                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("Дан файл С:\\DataSprint5\\InPutDataFileTask7V25.txt\n" +
    "(файл взять из архива согласно вашему варианту)\n" +
    "Создать папку вручную С:\\DataSprint5\\ и скопировать в неё файл),\n" +
    "В котором есть набор символьных данных\n" +
    "Удалить все английские слова из файла\n" +
    "Полученный результат сохранить в файл OutPutDataFileTask7V25.txt.                                       ");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine($"Данные находятся в файле: {path}                                                         ");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"Находится в файле: {res}");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();