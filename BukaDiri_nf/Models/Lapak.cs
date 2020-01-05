using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BukaDiri_nf.Models
{
    [Table("Lapak")]
    public class Lapak
    {
        [Key]
        [MaxLength(5)]
        public string kodeLapak { get; set; }
        public string namaLapak { get; set; }
        public int peringkatLapak { get; set; }
        //public int isDelete { get; set; }
    }
}