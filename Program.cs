/*Console.WriteLine("Введи путь файла"); // D:\\C#papkatesti\\abiba.txt
string inputPath = Console.ReadLine();
using StreamReader reader = new StreamReader(inputPath); // создаем объект класса по введенному пути (файл)
{
    string a = reader.ReadToEnd(); // читаем и записываем в переменную содержимое файла

    string newPath = "D:\\VScsharpiksprojects\\THELab14.1\\abiba2.txt"; //создание файла в папке с проектом abiba2.txt
    FileInfo newFileInfo = new FileInfo(newPath);
    if (newFileInfo.Exists)
    {
        using (StreamWriter writer = new StreamWriter(newPath, true)) //записываем в созданный файл данные из переменной а
        {
            writer.WriteLine(a);
        }
    }
    else
    {
        newFileInfo.Create(); //создаем файл, если он не существует
        using (StreamWriter writer = new StreamWriter(newPath, true))
        {
            writer.WriteLine(a);
        }
    }
    using (StreamReader sr = new StreamReader(newPath)) 
    {
        string read = sr.ReadToEnd(); // читаем файл в папке проекта
        Console.WriteLine(read);
    }
}*/



// using нужен только когда идет работа с большими файлами или потоковой обработкой

Console.WriteLine("Введи путь файла"); //D:\\C#papkatesti\\abiba.txt
string inputPath = Console.ReadLine();

string content = File.ReadAllText(inputPath);
string newPath = "D:\\VScsharpiksprojects\\THELab14.1\\abiba2.txt";

File.AppendAllText(newPath, "\n" + content); // File.WriteAllText(newPath, content); если нужно перезаписать
Console.WriteLine(File.ReadAllText(newPath));





/*Console.WriteLine("Введи путь файла");
string inputPath = Console.ReadLine();

try
{
    string content = File.ReadAllText(inputPath);
    string newPath = "D:\\VScsharpiksprojects\\THELab14.1\\abiba2.txt";

    File.AppendAllText(newPath, content);
    Console.WriteLine(File.ReadAllText(newPath));
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}*/
