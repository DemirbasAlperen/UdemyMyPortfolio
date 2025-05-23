using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        // Mesaj Durumu butonu
        public IActionResult ChangeIsReadToTrue(int id)    // Mesajın okunma durumu true ise
        {
            var value = context.Messages.Find(id);     // id ye göre mesajı bul
            value.IsRead = true;                     // mesaj değerini true yap
            context.SaveChanges();                   // değişiklikleri kaydet
            return RedirectToAction("Inbox");         // beni tekrar mesaj kutusuna yönlendir
        }
        public IActionResult ChangeIsReadToFalse(int id)    // Mesajın okunma durumu false ise
        {
            var value = context.Messages.Find(id);     // id ye göre mesajı bul
            value.IsRead = false;                     // mesaj değerini false yap
            context.SaveChanges();                   // değişiklikleri kaydet
            return RedirectToAction("Inbox");         // beni tekrar mesaj kutusuna yönlendir
        }

        // Mesaj Silme butonu
        public IActionResult DeleteMessage(int id)   // id ye göre silme yapılacak
        { 
            var value = context.Messages.Find(id);    // id ye göre mesajı bul
            context.Messages.Remove(value);           // value içine atanan mesajı sil
            context.SaveChanges();                    // değişiklikleri kaydet
            return RedirectToAction("Inbox");          // beni tekrar mesaj kutusuna yönlendir
        }

        // Mesajı Aç butonu
        public IActionResult MessageDetail(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);  
        }
    }
}
