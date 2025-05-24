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
                // Giriş başarılı
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Kullanıcı adı veya şifre yanlış!";
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(string oldPassword, string newPassword, string confirmPassword)
        {
            // Giriş yapmış kullanıcı örneğiyle çalışıldığını varsayalım (örnek kullanıcı Id: 1)
            var user = _context.Admins.FirstOrDefault(x => x.Id == 1);

            if (user != null && user.Password == oldPassword)
            {
                if (newPassword == confirmPassword)
                {
                    user.Password = newPassword;
                    _context.SaveChanges();
                    ViewBag.Message = "Şifre başarıyla güncellendi.";
                }
                else
                {
                    ViewBag.Error = "Yeni şifreler uyuşmuyor.";
                }
            }
            else
            {
                ViewBag.Error = "Eski şifre yanlış.";
            }

            return RedirectToAction("Index");
        }

    }
}
