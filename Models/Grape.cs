using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWineAPP.Models
{
    public class Grape
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GrapeID { get; set; }
        public string WhiteGrape { get; set; }
        public string RedGrape { get; set; }
        public int Rating { get; set; }

        public ICollection<WineType> WineType { get; set; }
    }
}
