using AdvancedCsharp;
using Csharp;
using System.Collections.Generic;
using System.Linq;
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        //left join or left outer join:
        //With LEFT OUTER JOIN all the matching elements +all the non-matching elements
        //from the left collection are included in the result set.
        var info3 = Vendors.GetAllVendors()//left side
            .GroupJoin(Planners.GetAllPlanners(),//right side
            vend => vend.Id,
            plan => plan.EmailId,
            (vend, plan) => new { vend, plan }).SelectMany(
            t => t.plan.DefaultIfEmpty(),
            (a, b) => new
            {
                VendorsName = a.vend.Name,
                PlannersName = b == null ? "Vendors not disclosed" : b.Name
            }
            );

        foreach (var data in info3)
        {
            Console.WriteLine($"VendorsName : {data.VendorsName}, PlannersName : {data.PlannersName}");
        }
        Console.WriteLine("---------");

        left join in query syntax
            var info4 = from plan in Planners.GetAllPlanners()
                        join vend in Vendors.GetAllVendors()
                        on plan.EmailId equals vend.Id
                        into Planvend
                        from vend2 in Planvend.DefaultIfEmpty()
                        select new
                        {
                            plan.Name,
                            VendName = vend2.Name == null ? "Vendors not disclosed" : vend2.Name

                        };
        foreach (var data in info4)
                            {
                               Console.WriteLine($"VendorsName : {data.VendName}, PlannersName : {data.Name}");
                            }
                            //innerJoin :In LINQ, an inner join is used to serve a result
                            //which contains only those elements from the first data source
                            //that appears only one time in the second data source.
                            //And if an element of the first data source does not have matching elements,
                            //then it will not appear in the result data set.
                            //extensionmethod

            //        var info = Eventinfo.GetAllEventinfo()//outer sequence
            //            .Join(Planners.GetAllPlanners(),//inner sequence
            //            even => even.Id,//outerKeySelector
            //            plan => plan.EmailId,//innerKeySelector
            //            (even, plan) => new //result selector
            //            {
            //                PlannerId = plan.EmailId,
            //                EventName = even.Name,
            //                VendorDescription = even.Description

            //            }).ToList();

            //        foreach (var data in info)
            //        {
            //            Console.WriteLine($"Id : {data.PlannerId}, Name : {data.EventName}, Description : {data.VendorDescription}");
            //        }
            //        Console.WriteLine("------------");
            //        //join in query syntax

            //        var info2 = (from vend in Vendors.GetAllVendors()//outer sequence
            //                     join plan in Planners.GetAllPlanners() //inner sequence
            //                     on vend.Id equals plan.EmailId//key selector
            //                     select new
            //                     {//result selector
            //                         PlannerId = plan.EmailId,
            //                         VendorName = vend.Name,
            //                         VendorDescription = vend.Description
            //                     }).ToList();
            //        foreach (var data in info2)
            //        {
            //            Console.WriteLine($"Id : {data.PlannerId}, Name : {data.VendorName}, Description : {data.VendorDescription}");
            //        }

    }
}
