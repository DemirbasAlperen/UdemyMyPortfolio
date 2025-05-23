using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();    // yetenek sayısı
            ViewBag.v2 = context.Messages.Count();   // toplam mesaj sayısı
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();   // okunmayan mesajların sayısı
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();   // okunan mesajların sayısı
            return View();  
        }
    }
}
