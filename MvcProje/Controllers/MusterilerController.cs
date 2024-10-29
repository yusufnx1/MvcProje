using MvcProje.Models.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MvcDbStokEntities mvc = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var value = mvc.TBLMusteri.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult MusteriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MusteriEkle(TBLMusteri tBLMusteri)
        {
            mvc.TBLMusteri.Add(tBLMusteri);
            mvc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MusteriSil(int id)
        {
            var value = mvc.TBLMusteri.Find(id);
            mvc.TBLMusteri.Remove(value);
            mvc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult MusteriGuncelle(int id)
        {
            var value = mvc.TBLMusteri.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult MusteriGuncelle(TBLMusteri m1)
        {
            var value = mvc.TBLMusteri.Find(m1.MusteriId);
            value.MusteriAd = m1.MusteriAd;
            value.MusteriSoyad = m1.MusteriSoyad;  
            mvc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}