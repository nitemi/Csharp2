using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp
{
    public  class Planners
    {
        public int EmailId {  get; set; }
        public string Name { get; set; }
        public static List<Planners> GetAllPlanners()
        {
            return new List<Planners>()
            {

                new Planners { EmailId = 1, Name = "Swift Event Planners"},
                new Planners { EmailId = 2, Name = "Adex Event Planners"},
                new Planners { EmailId = 3, Name = "ITX Event Planners"},
                new Planners { EmailId = 4, Name = "BigG Event Planners"}

            };
            
        }
    }
}
