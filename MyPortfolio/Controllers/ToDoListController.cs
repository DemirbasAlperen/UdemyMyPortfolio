using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();     // context örneğini sayfamıza çektik
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();      // ToDoLists i listeledik.
            return View(values);
        }

        // Yapılacakları ekleme işlemi
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;      // başlangıçta yapılacak işlem false olarak gelecek
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Silme işlemi
        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Güncelleme işlemi
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);      // id ye göre değeri bul
            return View(value);                        // değeri bize döndür
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Durum(status) değişimi (yapıldı mı yapılmadı mı)
        public IActionResult ChangeToDoListStatusToTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
