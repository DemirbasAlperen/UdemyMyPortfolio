using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SocialController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult SocialList()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        }

        // Ekleme İşlemi
        [HttpGet]
        public IActionResult CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocial(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialList"); 
        }

        // Silme işlemi
        public IActionResult DeleteSocial(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SocialList");
        }

        // Güncelleme İşlemi
        [HttpGet]
        public IActionResult UpdateSocial(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocial(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialList");
        }
    }
}
