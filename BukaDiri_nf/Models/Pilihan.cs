using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BukaDiri_nf.Models
{
    [Table("Pilihan")]
    public class Pilihan
    {
        [Key]
        [MaxLength(5)]
        public string kodePilihan { get; set; }
        public string namaPilihan { get; set; }
        public int diskonPilihan { get; set; }
        //public int isDelete { get; set; }
    }
}