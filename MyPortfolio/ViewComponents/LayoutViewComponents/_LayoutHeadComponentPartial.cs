using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent        // Layout un Head componenti için
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
