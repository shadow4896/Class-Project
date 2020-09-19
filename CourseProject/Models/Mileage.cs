using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Mileage
    {
        public int TripID { get; set; }
        public string BikeID { get; private set; }
        public double Miles { get; set; }
        public string Destination { get; set; }
        public string Date { get; set; }
    }
}
