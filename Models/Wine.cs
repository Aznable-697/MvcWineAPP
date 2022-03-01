﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWineAPP.Models
{
    public class Wine
    {
        public int WineID { get; set; }
        public string Vineyard { get; set; }
        public string WineName { get; set; }
        public int WineVintage { get; set; }
        public string PairsWith { get; set; }       
        public string WineTypes { get; set; }
        public int DateAdded { get; set; }

       // public ICollection<WineType> WineType { get; set; }

    }
}
