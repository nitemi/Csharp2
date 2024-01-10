using AdvancedCsharp;
using Csharp;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;
using System.Security;

public class Program
{
    //Task
    //Thread
    //Async

    //Ordering
    private static void Main(string[] args)
    {

        digitalClock();
    //    digitalResult();
       Console.Read();
    }
    //static void digitalResult()
    //{
    //    Task.Run(() =>
    //    {
    //        Digital();
    //    });
    //    Task.Run(() =>
    //    {
    //        Digital1();
    //    });
    //    Task.Run(() =>
    //    {
    //        Digital2();
    //    });
    //    Task.Run(() =>
    //    {
    //        Digital3();
    //    });
    //}
    //static int Digital()
    //{

    //    Console.WriteLine("Engaging Result 1.......");
    //    return 100;

    //}
    //static int Digital1()
    //{
    //    Thread.Sleep(5000);
    //    Console.WriteLine("Engaging Result 2.......");
    //    return 200;

    //}
    //static int Digital2()
    //{
    //    Console.WriteLine("Engaging Result 3.......");
    //    return 300;

    //}
    //static int Digital3()
    //{
    //    Console.WriteLine("Engaging Result 4.......");
    //    return 400;

    //}
    //static async Task Dat()//asyn method
    //{
    //    Console.WriteLine(digitalResult);
    //}
    public async static void digitalClock()
    {
        Console.WriteLine("Digital Clock ticks");
        await wait();
        Console.WriteLine("Digital clock stops ticking");

    }
    public async static Task wait()
    {
        await Task.Delay(TimeSpan.FromSeconds(10));
        Console.WriteLine("Ticks completed");
    }
}