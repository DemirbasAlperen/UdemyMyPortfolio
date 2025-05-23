using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent       // section (Feature) için tanımlanan component
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();    // Context yapımızı burada örnekledik. Clean koda uygun değildir amam bu projede kullanabiliriz. Başka bir yöntemde private readonly'dir. 

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();     // PortfolioContext da yer alan Features tablomu listeledim ve values içine atadım.
            return View(values);      // values içine atanan değerleri döndürdüm
        }
    }
}
