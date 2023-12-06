﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp
{
    public class Vendors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public static List<Vendors> GetAllVendors()
        {
            return new List<Vendors>()
            {
                //public static List<Vendors> vendor = new List<Vendors>{}
                new Vendors { Id = 1, Name = "Toke's  cakes  and  more", Description = "Cake Vendor" },
                new Vendors { Id = 2, Name = "Saveth Catering Services", Description = "Food Vendor" },
                new Vendors { Id = 3, Name = "Blue Ribbon Event Centre", Description = "Venue Vendor" },
                new Vendors { Id = 4, Name = "Precious cakes&surprises", Description = "Cake Vendor" },
                new Vendors { Id = 5, Name = "B&G  CateringandServices", Description = "Food Vendor" },
                new Vendors { Id = 1, Name = "MC  KayTy  Crew and Crew", Description = "Entertainment Vendor" },
                new Vendors { Id = 5, Name = "Swift Cars Transportater", Description = "Logistics Vendor" },
                new Vendors { Id = 4, Name = "The Podium Event  Centre", Description = "Venue Vendor" },
                new Vendors { Id = 2, Name = "TimK  Traditional Attire", Description = "Traditional Cloth Vendor" },
                new Vendors { Id = 2, Name = "Ashake Corporate  Ushers", Description = "Ushers Vendor" }
            };
        }
    }
}