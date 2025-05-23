using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent       // deneyimler için tanımlanan component
    {
        MyPortfolioContext context = new MyPortfolioContext();    // Context yapımızı burada örnekledik.
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
