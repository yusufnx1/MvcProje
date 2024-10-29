using MvcProje.Models.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        MvcDbStokEntities c = new MvcDbStokEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSatis p)
        {
            c.TBLSatis.Add(p);  
            c.SaveChanges();
            return View("Index");
        }
    }
}