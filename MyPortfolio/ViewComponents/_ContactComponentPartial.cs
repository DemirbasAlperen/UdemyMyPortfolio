using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent         // contact(iletişim) için tanımlanan component
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
