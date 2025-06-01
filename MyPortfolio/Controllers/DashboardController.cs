using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            // Yeteneklerin ortalaması
            var averageSkill = context.Skills.Select(x => Convert.ToInt32(x.Value)).Average();
            ViewBag.skill3 = Math.Round(averageSkill, 0);    // Virgülden sonra 0 basamak alır yani yuvarlar

            // TodoList yapısı
            var todoList = context.ToDoLists.OrderByDescending(x => x.Date).Take(20).ToList();
            ViewBag.TodoList = todoList;

            return View();
        }
    }
}
