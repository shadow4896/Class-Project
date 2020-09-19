using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class EmergencyContact
    {
        public string EmergencyName { get; set; }
        public int UserId { get; set; }
        public double EmergencyPhoneNum { get; private set; }
        public string Relation  { get; set; }
    }
}
