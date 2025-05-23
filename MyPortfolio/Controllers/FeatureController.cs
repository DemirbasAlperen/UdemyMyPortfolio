using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult FeatureList()         // Listeleme
        {
            var value = context.Features.ToList();
            return View(value);
        }

        [HttpGet]
        // Güncelleme İşlemi
        public IActionResult UpdateFeature(int id)
        {
            var values = context.Features.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
