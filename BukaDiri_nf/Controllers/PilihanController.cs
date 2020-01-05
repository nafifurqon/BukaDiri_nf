using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BukaDiri_nf.Context;
using BukaDiri_nf.Models;

namespace BukaDiri_nf.Controllers
{
    public class PilihanController : Controller
    {
        //instansiasi context
        private BukaDiriContext db = new BukaDiriContext();
        //
        // GET: /Pilihan/
        //method index
        public ActionResult Index()
        {
            return View(db.Pilihan.ToList());
        }

        //method untuk nambah data
        public ActionResult Tambah()
        {
            return View();
        }

        //method untuk mengirim data yang ditambah ke database
        [HttpPost]
        public ActionResult Simpan(Pilihan pil)
        {
            db.Pilihan.Add(pil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk melihat detail sebuah data
        [HttpGet]
        public ActionResult Lihat(string id)
        {
            Pilihan pil = db.Pilihan.Find(id);

            return View(pil);
        }

        //method untuk edit sebuah data
        [HttpGet]
        public ActionResult Edit(string id)
        {
            Pilihan pil = db.Pilihan.Find(id);

            return View(pil);
        }

        //method untuk mengirim data yang diubah ke database
        [HttpPost]
        public ActionResult Update(Pilihan pil)
        {
            db.Entry(pil).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk menghapus sebuah data
        [HttpGet]
        public ActionResult Hapus(string id)
        {
            Pilihan pil = db.Pilihan.Find(id);
            db.Pilihan.Remove(pil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}