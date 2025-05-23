using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult PortfolioList()         // Listeleme
        {
            var value = context.Portfolios.ToList();
            return View(value);
        }

        // Ekleme işlemi
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");

        }

        // Silme  İşlemi 
        public IActionResult DeletePortfolio(int id)       // Silme işlemi id ye göre yapılır
        {
            var value = context.Portfolios.Find(id);      // id ye göre bul ve value içine at
            context.Portfolios.Remove(value);            // value den gelen değeri sil
            context.SaveChanges();                        // değişiklikleri kaydet
            return RedirectToAction("PortfolioList");   // yukarıdaki işlemlerden sonra beni tekrar PortfolioList e yönlendir
        }

        // Güncelleme işlemi
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = context.Portfolios.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
