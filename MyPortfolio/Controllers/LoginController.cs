using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class LoginController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var user = _context.Admins.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user != null)
            {
                var value = _context.Admins.Where(x => x.Password == "true");
                return RedirectToAction("ExperienceList", "Experience");       // Normalde /Index/Layout/ olmalı fakat index te Renderbody olduğu için sayfa çalışmıyor. Onun yerine yolu Experince tanımladık. Bunu daha sonra Dashboard olarak tanımlayacağız. 
            }

            ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }

    }
}
