using MvcProje.Models.Entitiy;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;

namespace MvcProje.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: Urunler
        MvcDbStokEntities mvb = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var value = mvb.TBLUrunler.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> deger = (from i in mvb.TBLKategoriler.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.KategoriAd,
                                              Value = i.KategoriId.ToString()
                                          }).ToList();
            ViewBag.d = deger;
            return View();
        }
        [HttpPost]

        public ActionResult UrunEkle(TBLUrunler tBL)
        {
            mvb.TBLUrunler.Add(tBL);
            mvb.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var value = mvb.TBLUrunler.Find(id);
            mvb.TBLUrunler.Remove(value);
            mvb.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UrunGuncelle(int id)
        {
            List<SelectListItem> deger = (from i in mvb.TBLKategoriler.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.KategoriAd,
                                              Value = i.KategoriId.ToString()
                                          }).ToList();
            ViewBag.d = deger;
            var value = mvb.TBLUrunler.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UrunGuncelle(TBLUrunler p1)
        {
            var urun = mvb.TBLUrunler.Find(p1.UrunId);
            urun.UrunAd = p1.UrunAd;
            urun.Stok = p1.Stok;
            urun.Marka = p1.Marka;
            urun.Fiyat = p1.Fiyat;

            var ktg = mvb.TBLKategoriler.Where(c => c.KategoriId == p1.TBLKategoriler.KategoriId).FirstOrDefault();
            urun.UrunKategori = ktg.KategoriId;

            mvb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}