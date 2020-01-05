using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BukaDiri_nf.Models
{
    public class Home
    {
        public Item Item { get; set; }
        public Provinsi Provinsi { get; set; }
        public Pilihan Pilihan { get; set; }
        public Lapak Lapak { get; set; }
    }
}