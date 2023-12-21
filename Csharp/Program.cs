using AdvancedCsharp;
using Csharp;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.PortableExecutable;
using System.Security;

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

        //var info = from v in Vendors.GetAllVendors()
        //           join p in Planners.GetAllPlanners()
        //           on v.Id equals p.EmailId
        //           select new
        //           {

        //               VendorsId = v.Id,
        //               VendorsName = v.Name,
        //               PlannersName = p.Name,
        //           };

        ////method syntax
        //var info1 = Vendors.GetAllVendors()
        //    .Join(Planners.GetAllPlanners(),
        //    p => p.Id,
        //    v => v.EmailId,
        //    (p, v) => new
        //    {
        //        VendorsId = p.Id,
        //        VendorsName = p.Name,
        //        PlannersName = v.Name,
        //    });

        //foreach ( var record in info1 )
        //{
        //    Console.WriteLine("VendorsId:  {0}, \tVendorsName:  {1}, \tPlannersName:  {2}", record.VendorsId, record.VendorsName, record.PlannersName);
        //}

        //Groupjoin
        //query syntax
        var groupinfo1 = from v in Vendors.GetAllVendors()
                         join p in Planners.GetAllPlanners()
                         on v.Id equals p.EmailId into groupinfo
                         select new
                         {

                             VendorsName = v.Name,
                             Planners = groupinfo
                         };
        //method syntax
        //var groupinfo2 = Planners.GetAllPlanners()
        //    .GroupJoin(Vendors.GetAllVendors(),
        //    p => p.EmailId,
        //    v => v.Id,
        //    (v1, groupda) => new
        //    {
        //        VendorsName = v1.Name,
        //        Planners = groupda
        //    });

        //foreach (var record in groupinfo2)
        //{
        //    Console.WriteLine($"-------{record.VendorsName}, --------{record.Planners.Count()}");
        //    foreach (var record2 in record.Planners)
        //    {
        //        Console.WriteLine("VendorsId:  {0}, \tVendorsName:  {1}", record2.Id, record2.Name);
        //    }
        //}

        //leftjoin
        //query syntax

        //var vendor = from v in Vendors.GetAllVendors()
        //             join p in Planners.GetAllPlanners()
        //             on v.Id equals p.EmailId into groupinfo
        //             from gc in groupinfo.DefaultIfEmpty()
        //             select new
        //             {
        //                 VendorsId = v.Id,
        //                 PlannersName = gc == null ? "N/A" : gc.Name,
        //             };
        //foreach (var v in vendor)
        //{
        //    Console.WriteLine("VendorsId:  {0}, \tPlannersName:  {1}", v.VendorsId, v.PlannersName);
        //}
        //method syntax
        //var vendors = Vendors.GetAllVendors()
        //    .GroupJoin(Planners.GetAllPlanners(),
        //    p => p.Id,
        //    v => v.EmailId,
        //    (pl, vl) => new { pl, vl }).SelectMany
        //    (x => x.vl.DefaultIfEmpty(),
        //    (p, v) => new
        //    {
        //        VendorsName = p.pl.Name,
        //        PlannersName = v == null? "N/A" : v.Name,
        //    });
        //foreach (var v in vendors)
        //{
        //    Console.WriteLine("VendorsName:  {0}, \tPlannersName:  {1}", v.VendorsName, v.PlannersName);
        //}

        //conversion method

        //var itit = Vendors.GetAllVendors();
        //var rec = itit.ToArray();
        //Console.WriteLine(rec);

        //agregate operators has to do with calculation
        //average,count,max,min,sum
        var itit = Vendors.GetAllVendors();
        var rec = itit.Min(x => x.Id);
        Console.WriteLine("Min value: {0}", rec);
        var rec1 = itit.Max(x => x.Id);
        Console.WriteLine("Max value: {0}",rec1);
        var rec2 = itit.Sum(x => x.Id);
        Console.WriteLine("Sum: {0}", rec2);
        var rec3 = itit.Count();
        Console.WriteLine("Count value: {0}", rec3);
        var rec4 = itit.Average(x => x.Id);
        Console.WriteLine("Average value: {0}", rec4);

    }
}
