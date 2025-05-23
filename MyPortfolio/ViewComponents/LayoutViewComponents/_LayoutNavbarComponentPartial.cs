using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent        // Layout un Navbar(class="main-header") componenti için
    {
        MyPortfolioContext context = new MyPortfolioContext();     // bildirimlerin dinamikliği için context örneği türettik
        public IViewComponentResult Invoke()          
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();   // yapılmamış olan bildirimlerin sayısı
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();   // henüz yapılmamış bildirimler listelenecek
            return View(values);
        }
    }
}
