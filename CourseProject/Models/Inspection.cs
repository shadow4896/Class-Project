using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public enum TCLOCK
    {
        Yes, No
    }

    public class Inspection
    {
        public int ServiceNum { get; set; }
        public string BikeId { get; set; }
        public string ServiceType { get; set; }
        public string ServiceDate { get; set; }
        public string ServiceDue { get; set; }
        public TCLOCK? TCLOCK { get; set; }
    }
}

