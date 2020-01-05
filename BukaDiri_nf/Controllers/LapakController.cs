using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BukaDiri_nf.Context;
using BukaDiri_nf.Models;

namespace BukaDiri_nf.Controllers
{

    public class LapakController : Controller
    {
        private BukaDiriContext db = new BukaDiriContext();
        //
        // GET: /Lapak/
        //method index
        public ActionResult Index()
        {
            return View(db.Lapak.ToList());
        }

        //method untuk nambah data
        public ActionResult Tambah()
        {
            return View();
        }

        //method untuk mengirim data yang ditambah ke database
        [HttpPost]
        public ActionResult Simpan(Lapak lapak)
        {
            db.Lapak.Add(lapak);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk melihat detail sebuah data
        [HttpGet]
        public ActionResult Lihat(string id)
        {
            Lapak lapak = db.Lapak.Find(id);

            return View(lapak);
        }

        //method untuk edit sebuah data
        [HttpGet]
        public ActionResult Edit(string id)
        {
            Lapak lapak = db.Lapak.Find(id);

            return View(lapak);
        }

        //method untuk mengirim data yang diubah ke database
        [HttpPost]
        public ActionResult Update(Lapak lapak)
        {
            db.Entry(lapak).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk menghapus sebuah data
        [HttpGet]
        public ActionResult Hapus(string id)
        {
            Lapak lapak = db.Lapak.Find(id);
            db.Lapak.Remove(lapak);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}