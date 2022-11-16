using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ConsoleApp7;

class Program // ищет путь
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите путь: ");
        string path = Console.ReadLine();

        reader p1 = new reader();
        string t = p1.read(path);
       
    }

}
class reader // читает путь, не находит создает
{
    public string read(string path)
    {
        if (File.Exists(path))
        {
            string txt = File.ReadAllText(path);
            return txt;
        }
        else
        {
            File.Create(path);
            return "File created";
        }
    }


}

