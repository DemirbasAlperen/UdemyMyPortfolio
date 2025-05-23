using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();     // context sınıfımdan bir nesne örneği türettim   
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        // Ekleme(Create) İşlemi
        [HttpGet]         // sayfa yüklenince çalışır     
        public IActionResult CreateExperience()       // Sayfanın boş gelmesi için 
        {
            return View();
        }

        [HttpPost]      // sayfada bir butona tıklanınca çalışır 
        public IActionResult CreateExperience(Experience experience)          // Yukarıdaki metot ile aynı isme sahiptir fakat farklı olarak burada parametre bulunur
        {
            context.Experiences.Add(experience);    // parametreden gelen değerler ile ekleme işlemini yap
            context.SaveChanges();          // değişiklikleri veri tabanına kaydet   
            return RedirectToAction("ExperienceList");    // yukarıdaki işlemlerden sonra beni tekrar ExperienceList e yönlendir
        }

        // Silme  İşlemi 
        public IActionResult DeleteExperience(int id)       // Silme işlemi id ye göre yapılır
        {
            var value = context.Experiences.Find(id);      // id ye göre bul ve value içine at
            context.Experiences.Remove(value);            // value den gelen değeri sil
            context.SaveChanges();                        // değişiklikleri kaydet
            return RedirectToAction("ExperienceList");   // yukarıdaki işlemlerden sonra beni tekrar ExperienceList e yönlendir
        }

        // Güncelleme İşlemi
        [HttpGet]
        public IActionResult UpdateExperience(int id)    // id ye göre işlem yapacağız 
        {
            var value = context.Experiences.Find(id);     // context içinden id ye göre bulup value içine atayacak
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)    
        {
            context.Experiences.Update(experience);      // parametreden gelen değeri güncelle
            context.SaveChanges();                       // güncelleme değişikliklerini kaydet
            return RedirectToAction("ExperienceList");    // yukarıdaki işlemlerden sonra beni tekrar ExperienceList e yönlendir
        }
    }
}
