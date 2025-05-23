using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent      // about içinde bulunan yetenekler(skill) bölümünün componenti
    {
        MyPortfolioContext context = new MyPortfolioContext();      // / Context yapımızı burada örnekledik.
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
