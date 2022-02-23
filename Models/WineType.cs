using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWineAPP.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class WineType
    {
        public int WineTypeID { get; set; }
        public int WineID { get; set; }
        public int GrapesID { get; set; }

        public Grade? Grade { get; set; }

        public Grape Grape { get; set; }
        public Wine Wine { get; set; }
    }
}