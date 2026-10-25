using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFlexAutomation.Entities
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int TrainerID { get; set; }
        public int TypeID { get; set; }
        public string QRCodeText { get; set; }
    }
}
