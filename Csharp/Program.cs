using AdvancedCsharp;
using Csharp;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;

public class Program
{
    //joining
    //Grouping
    //Ordering

    //Join:In LINQ, Join operators are used for integrating two data source into one data source
    //which shares some common attributes
    // inner join ---- outer join:With INNER JOIN only the matching elements are included in
    // the result set. Non-matching elements are excluded from the result set.
    // left join --------- left outer join
    // right join ------- right outer join
    //full join


    //Ordering
    private static void Main(string[] args)
    {
        //Ordering
        //orderby
        //orderbydescending
        //thenby
        //thenbydecending
        //var vend = Vendors.GetAllVendors()
        //            .OrderBy(v => v.Id)
        //            .ThenBy(v => v.Name)
        //            .ToList();

        //foreach (var v in vend)
        //{
        //    Console.WriteLine("Name:" + v.Name + "\t" + "Id:" + v.Id);
        //}

        //Grouping
        //groupby
        //query syntax
        var info = (from vn in Vendors.GetAllVendors()
                    group vn by vn.Id);

        //method syntax
        var info1 = Vendors.GetAllVendors().GroupBy(v => v.Id);

        foreach ( var data in info)
        {
            Console.WriteLine(data.Key + ":" + data.Count());
            foreach ( var v in data)
            {
                Console.WriteLine("Name:" + v.Name);
            }
        }
        

        //set operator
        //Distinct
        //Except
        //Intersect
        //union
        Console.WriteLine("------------");
        var datainfo = new List<string> { "ade", "femi", "ife","beloved","femi", "williams", "uchechi" };
        var datainfo1 = new List<string> { "gift","ade", "femi","beloved", "emmanuel", "adeyemi", "euchaura" };

        //method syntax
        var record = datainfo.Distinct().ToList();

        //query syntax
        var record1 = (from nil in datainfo select nil).Distinct();
            foreach ( var v in record)
        {
            Console.WriteLine(v);
        }
        Console.WriteLine("---------");

        //Except
        //method syntax
        var record2 = datainfo.Except(datainfo1).ToList();
            foreach ( var v1 in record2)
        {
            Console.WriteLine(v1);
        }
        Console.WriteLine("***********");

        //intersect
        //method syntax
        var record3 = datainfo1.Intersect(datainfo).ToList();
        foreach (var v2 in record3)
        {
            Console.WriteLine(v2);
        }
        Console.WriteLine("**********");

        //union
        //method syntax
        var record4 = datainfo.Union(datainfo1).ToList();
        foreach ( var v3 in record4)
        {
            Console.WriteLine(v3);
        }
            Console.ReadKey();     
        

    }
}
