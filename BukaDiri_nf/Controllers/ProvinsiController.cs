using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BukaDiri_nf.Context;
using BukaDiri_nf.Models;

namespace BukaDiri_nf.Controllers
{
    public class ProvinsiController : Controller
    {
        //instansiasi context
        private BukaDiriContext db = new BukaDiriContext();
        //
        // GET: /Provinsi/
        //method index
        public ActionResult Index()
        {
            return View(db.Provinsi.ToList());
        }

        //method untuk nambah data
        public ActionResult Tambah()
        {
            return View();
        }

        //method untuk mengirim data yang ditambah ke database
        [HttpPost]
        public ActionResult Simpan(Provinsi prov)
        {
            db.Provinsi.Add(prov);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk melihat detail sebuah data
        [HttpGet]
        public ActionResult Lihat(string id)
        {
            Provinsi prov = db.Provinsi.Find(id);

            return View(prov);
        }

        //method untuk edit sebuah data
        [HttpGet]
        public ActionResult Edit(string id)
        {
            Provinsi prov = db.Provinsi.Find(id);

            return View(prov);
        }

        //method untuk mengirim data yang diubah ke database
        [HttpPost]
        public ActionResult Update(Provinsi prov)
        {
            db.Entry(prov).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //method untuk menghapus sebuah data
        [HttpGet]
        public ActionResult Hapus(string id)
        {
            Provinsi prov = db.Provinsi.Find(id);
            db.Provinsi.Remove(prov);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

	}
}