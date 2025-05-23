using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent      // Layout un Sidebar componenti için
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
