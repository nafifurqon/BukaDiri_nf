using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BukaDiri_nf.Models;
using System.Data.Entity;

namespace BukaDiri_nf.Context
{
    public class BukaDiriContext : DbContext
    {
        public DbSet<Provinsi> Provinsi { get; set; }
        public DbSet<Pilihan> Pilihan { get; set; }
        public DbSet<Lapak> Lapak { get; set; }
        public DbSet<Item> Item { get; set; }
    }
}