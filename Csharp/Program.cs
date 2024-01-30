using AdvancedCsharp;
using Csharp;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;
using System.Security;

public class Program
{
    //Task
    //Thread
    //Async

    //Streams
    private static void Main(string[] args)
    {

        //stream is a class that is used to write to file and read to file
        //streamreader
        //try
        //{
        //    using (StreamReader sr = new StreamReader("C:\\Users\\user\\Downloads\\foundational-c-sharp-with-microsoft-certification-exam.txt"))
        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(line);
        //        }
        //    }
        //    Console.ReadKey();
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("file cannot be read");
        //    Console.WriteLine(e.Message);
        //}
        //}

        //string root = @"C:\\Users\\user\\Documents\\Hint";
        //string direct = @"C:\\Users\\user\\Documents\\Hint\\Names";

        //if (!Directory.Exists(root))
        //{
        //    Directory.CreateDirectory(root);
        //    File.Create(direct);
        //}
        //Console.Read();

        //streamwriter

        //string[] words = new string[] { "Ade", "Mimi", "Esra", "Fitur" };
        //using (StreamWriter sw = new StreamWriter("C:\\Users\\user\\Hint\\Names"))
        //{
        //    foreach (string word in words)
        //    {
        //        sw.WriteLine(word);
        //    }
        //}
        //string info;
        //using (StreamReader sr = new StreamReader("C:\\Users\\user\\Hint\\Names"))
        //{
        //    while ((info = sr.ReadLine()) != null)
        //    {
        //        Console.WriteLine(info);
        //    }
        //}

        //How to read and write using file

        string root = @"C:\\Users\\user\\Downloads";
        string direct = @"C:\Users\user\Downloads\foundational-c-sharp-with-microsoft-certification-exam.txt";
        //var word = File.ReadAllText(direct);
        var word = File.GetCreationTime(direct);
        Console.WriteLine(word);
       
    }
}