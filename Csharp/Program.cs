using Csharp;
using System.Collections;
using System.Diagnostics;
using System.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        //linq : Language integrated query
        //query syntax or query expression
        //method syntax or method extension syntax or fluent syntax
        //filtering has to do with where, pluss and offtype(use to select different typr of datatype)
        //projection: select and select many


        IList<Eventinfo> list = new List<Eventinfo>()
        {
            new Eventinfo() {id = 1, name = "Birthdays", description = "Mini birthday event"},
            new Eventinfo() {id = 2, name = "Weddings", description = "Mini and Classic wedding event"},
            new Eventinfo() {id = 3, name = "Corporate Events", description = "Mini Corporate event"},
            new Eventinfo() {id = 4, name = "Anniversary", description = "Classical event"},
            new Eventinfo() {id = 5, name = "House Warming", description = "Mini event"},
        };
        //query
        var minievent = from d in list
                        where d.id > 2
                        select d;

        //method syntax 
        var minievent2 = list.Where(d => d.id > 2);
       

        foreach (var eventinfo in minievent2.ToList())
        {
            Console.WriteLine(eventinfo.name + " ---------- " + eventinfo.description);
        }
        Console.WriteLine("--------------");
        
        IList values = new ArrayList();
        values.Add(0);
        values.Add("Bridal Shower");
        values.Add("Naming");
        values.Add(6);
        values.Add(7);

        var result = from d in values.OfType<string>()
                           select d;

        foreach (var info in result.ToList())
        {
            Console.WriteLine(info);
        }
        Console.WriteLine("!!!!!!!!!!!!!");
        var report = from d in values.OfType<int>()
                     select d;

        foreach (var resp in report.ToList())
        {
            Console.WriteLine(resp);
        }
        List<string> words = new List<string>() { "Noun", "Pronoun","Interjection", "Adjectives","Preposition", "Verb","Conjunction", "Adverb" };
        var result1 = words.SelectMany(w => w.ToList());//use when returning a very large list
        foreach(var word in result1)
        {
            Console.WriteLine(word);
        }
    }
}

        
