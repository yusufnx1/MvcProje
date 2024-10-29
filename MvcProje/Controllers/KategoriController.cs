using System.Linq;
using System.Web.Mvc;
using MvcProje.Models.Entitiy;

namespace MvcProje.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDbStokEntities mvc = new MvcDbStokEntities();
        public ActionResult Index()
        {
            var deger = mvc.TBLKategoriler.ToList();
            return View(deger);
        }
        public ActionResult KategoriSil(int id)
        {
            var value = mvc.TBLKategoriler.Find(id);
            mvc.TBLKategoriler.Remove(value);
            mvc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KategoriGuncelle(int id)
        {
            var value = mvc.TBLKategoriler.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult KategoriGuncelle(TBLKategoriler p1)
        {
            var kgt = mvc.TBLKategoriler.Find(p1.KategoriId);
            kgt.KategoriAd = p1.KategoriAd;
            mvc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(TBLKategoriler tBLKategoriler)
        {
            mvc.TBLKategoriler.Add(tBLKategoriler);
            mvc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}