using AdvancedCsharp;
using Csharp;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;

public class Program
{
    //joining
    //Convertion method
    //Element operators
    //Aggregate
    //Quantifier

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

        //innerjoin
        //query syntax

        var info = from v in Vendors.GetAllVendors()
                   join p in Planners.GetAllPlanners()
                   on v.Id equals p.EmailId
                   select new
                   {

                       VendorsId = v.Id,
                       VendorsName = v.Name,
                       PlannersName = p.Name,
                   };

        //method syntax
        var info1 = Vendors.GetAllVendors()
            .Join(Planners.GetAllPlanners(),
            p => p.Id,
            v => v.EmailId,
            (p, v) => new
            {
                VendorsId = p.Id,
                VendorsName = p.Name,
                PlannersName = v.Name,
            });

        foreach ( var record in info1 )
        {
            Console.WriteLine("VendorsId:  {0}, \tVendorsName:  {1}, \tPlannersName:  {2}", record.VendorsId, record.VendorsName, record.PlannersName);
        }
                  

    }
}
