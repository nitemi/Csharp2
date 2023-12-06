using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Eventinfo
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; } 
        
        public static List<Eventinfo>  GetAllEventinfo()
        {
            return new List<Eventinfo>()
            {
            new Eventinfo() { Id = 1, Name = "Birthdays", Description = "Mini birthday event" },
            new Eventinfo() { Id = 2, Name = "Weddings", Description = "Mini and Classic wedding event" },
            new Eventinfo() { Id = 3, Name = "Corporate Events", Description = "Mini Corporate event" },
            new Eventinfo() { Id = 4, Name = "Anniversary", Description = "Classical event" },
            new Eventinfo() { Id = 5, Name = "House Warming", Description = "Mini event" },
            };
        }
    }
}
