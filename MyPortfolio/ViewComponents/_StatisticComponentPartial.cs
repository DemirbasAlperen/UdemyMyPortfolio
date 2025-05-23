using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent        // statistic için tanımlanan component
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
