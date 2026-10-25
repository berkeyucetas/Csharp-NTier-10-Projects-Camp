using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFlexAutomation.Entities
{
    public class CheckIn
    {
        public int CheckInID { get; set; }
        public int MemberID { get; set; }
        public DateTime AccessTime { get; set; }
        public bool Status { get; set; }
    }
}
