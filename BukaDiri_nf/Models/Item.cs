using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BukaDiri_nf.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        [MaxLength(5)]
        public string kodeItem { get; set; }
        public string namaItem { get; set; }
        public int hargaItem { get; set; }
        //public int isDelete { get; set; }

        [MaxLength(5)]
        public string kodeProvinsi { get; set; }
        public Provinsi Provinsi { get; set; }

        [MaxLength(5)]
        public string kodePilihan { get; set; }
        public Pilihan Pilihan { get; set; }
        [MaxLength(5)]
        public string kodeLapak { get; set; }
        public Lapak Lapak { get; set; }
    }
}