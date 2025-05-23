using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent        // about için tanımlanan component
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();     // Context yapımızı burada örnekledik.
        public IViewComponentResult Invoke()          
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();     // About un Title ı için ViewBag
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();       // About un SubDescription ı için ViewBag
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();     // About un Detail ı için ViewBag
            return View();
        }
    }
}
