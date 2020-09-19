using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Motorcycle
    {
        public string BikeID { get; set; }
        public int UserID { get; private set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
