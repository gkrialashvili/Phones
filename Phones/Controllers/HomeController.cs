using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phones.Models;
using System.Data.Entity;
using Phones.ViewModels;

namespace Phones.Controllers
{
    public class HomeController : Controller
    {
        EFDBContext _db = new EFDBContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Brands = _db.Brands.ToList();
            var model = _db.PhoneDatas.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(SearchTermsVM searchTerms)
        {
            ViewBag.Brands = _db.Brands.ToList();

            var result = _db.PhoneDatas.Where(e => searchTerms.Brand != null ? e.Brand.Name.Contains(searchTerms.Brand) : true)
                                       .Where(e => searchTerms.Model != null ? e.Model.Contains(searchTerms.Model) : true)
                                       .Where(e => (searchTerms.maxPrice + searchTerms.minPrice > 0) ? e.Price <= searchTerms.maxPrice && e.Price >= searchTerms.minPrice : true)
                                       .ToList();

            return View(result);
        }
        public ActionResult Detail(int Id)
        {
            var model = _db.PhoneDatas.Include(r => r.Brand).FirstOrDefault(e => e.Id == Id);
            return View(model);
        }
    }
}