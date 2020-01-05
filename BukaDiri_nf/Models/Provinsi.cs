using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BukaDiri_nf.Models
{
    [Table("Provinsi")]
    public class Provinsi
    {
        [Key]
        [MaxLength(5)]
        public string kodeProvinsi { get; set; }
        public string namaProvinsi { get; set; }
        public int jumlahKotaProvinsi { get; set; }
        //public int isDelete { get; set; }
    }
}