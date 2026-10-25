using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFlexAutomation.Entities
{
    public class MembershipType
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public int DurationMonths { get; set; }
        public decimal Price { get; set; }
    }
}
