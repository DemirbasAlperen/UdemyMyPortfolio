using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent       // portfolio için tanımlanan component
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
