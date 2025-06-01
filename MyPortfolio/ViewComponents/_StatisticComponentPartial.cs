using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent        // statistic için tanımlanan component
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.exp1 = context.Experiences.Count();      // Deneyimlerin sayısı
            ViewBag.port1 = context.Portfolios.Count();   // Projelerin(portfolio) sayısı
            ViewBag.skill1 = context.Skills.Count();       // Yeteneklerin sayısı
            ViewBag.social1 = context.SocialMedias.Count();   // Sosyal Medya

            return View();
        }
    }
}
