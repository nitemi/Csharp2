using AdvancedCsharp;
using Csharp;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;
using System.Security;

public class Program
{
    //Element operators
    //Aggregate
    //Quantifier

    //Ordering
    private static void Main(string[] args)
    {

        //Quantifiers
        //Any
        //All
        //Contain

        string[] names = { "Gina", "Adnan", "Daniel", "John", "Abdu" };

        var name = names.Any(num => num.Length > 4);
        Console.WriteLine(name);

        var name2 = names.All(num => num.Length > 6 );
        Console.WriteLine(name2);

        var name3 = names.Contains("Adnan");
        Console.WriteLine(name3);
        //Element Operators
        //ElmentAt

        //List<int> names = new List<int>() { 11, 34, 6, 9, 23, 4 };
        //List<int> name = new List<int>() { };

        //var elements = names.ElementAt(3);
        //var elementts = name.ElementAtOrDefault(6);
        //Console.WriteLine(elements);

//        //First
//        //Firstordefault
//        var first = names.First();
//        var firsts = name.FirstOrDefault();
//        Console.WriteLine(first);

//        //last
//        //lastordefault
//        var last = names.Last();
//        var lasts = name.LastOrDefault();
//        Console.WriteLine(last);

//        //Single if the result is more than 1, it will throw an error
//        //singleordefault if the result is more than 1, it will return zero
//        var single = names.Single(name => name < 6);
//        var singles = name.SingleOrDefault(name => name > 6);
//        Console.WriteLine(singles);

//        //defaultifempty use for fetchng list, to avoid throwing an error if empty

//        var defaults = names.DefaultIfEmpty();
//        var defaultts = name.DefaultIfEmpty();
//        foreach (var element in defaults)
//        {
//            Console.WriteLine(element);
//        }

   }
}
