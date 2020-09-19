using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Insurance
    {
        public int PolicyNum { get; private set; }
        public string BikeID { get; set; }
        public string Company { get; set; }
        public string EffectiveDates { get; set; }
    }
}
