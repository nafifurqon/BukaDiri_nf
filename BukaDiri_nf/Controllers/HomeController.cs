using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BukaDiri_nf.Context;
using BukaDiri_nf.Models;

namespace BukaDiri_nf.Controllers
{
    public class HomeController : Controller
    {
        private BukaDiriContext db = new BukaDiriContext();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var DataHome =
                from a in db.Item
                join b in db.Provinsi on a.kodeProvinsi equals b.kodeProvinsi
                join c in db.Pilihan on a.kodePilihan equals c.kodePilihan
                join d in db.Lapak on a.kodeLapak equals d.kodeLapak
                select new Home { Item = a, Provinsi = b, Pilihan = c, Lapak = d  };
            return View(DataHome);
        }
	}
}