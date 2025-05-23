using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult SkillList()
        {
            var value = context.Skills.ToList();
            return View(value);
        }

        // Ekleme İşlemi
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            if (!ModelState.IsValid)         // ekleme sayfasında sayfa boş iken ekleme butonuna basınca hata vermemesi için eklendi
            {
                // Formu tekrar göster ve mevcut verileri koru
                return View(skill);
            }
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        // Silme işlemi (silme işlemlerinde view oluşturulmaz)
        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        // Güncelleme işlemi
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
