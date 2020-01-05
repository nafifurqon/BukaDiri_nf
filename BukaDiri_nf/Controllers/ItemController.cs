using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BukaDiri_nf.Context;
using BukaDiri_nf.Models;

namespace BukaDiri_nf.Controllers
{
    public class ItemController : Controller
    {
        private BukaDiriContext db = new BukaDiriContext();
        //
        // GET: /Item/
        //method index
        public ActionResult Index()
        {
            return View(db.Item.ToList());
        }

        //method untuk nambah data
        public ActionResult Tambah()
        {
            ViewData["Provinsi"] = db.Provinsi.ToList();
            ViewData["Pilihan"] = db.Pilihan.ToList();
            ViewData["Lapak"] = db.Lapak.ToList();
            return View();
        }

        //method untuk mengirim data yang ditambah ke database
        [HttpPost]
        public ActionResult Simpan(Item item)
        {
            db.Item.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk melihat detail sebuah data
        [HttpGet]
        public ActionResult Lihat(string id)
        {
            Item item = db.Item.Find(id);
            ViewData["Provinsi"] = db.Provinsi.ToList();
            ViewData["Pilihan"] = db.Pilihan.ToList();
            ViewData["Lapak"] = db.Lapak.ToList();
            return View(item);
        }

        //method untuk edit sebuah data
        [HttpGet]
        public ActionResult Edit(string id)
        {
            Item item = db.Item.Find(id);
            ViewData["Provinsi"] = db.Provinsi.ToList();
            ViewData["Pilihan"] = db.Pilihan.ToList();
            ViewData["Lapak"] = db.Lapak.ToList();
            return View(item);
        }

        //method untuk mengirim data yang diubah ke database
        [HttpPost]
        public ActionResult Update(Item item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk menghapus sebuah data
        [HttpGet]
        public ActionResult Hapus(string id)
        {
            Item item = db.Item.Find(id);
            db.Item.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}