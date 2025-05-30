using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent       // portfolio için tanımlanan component
    {
        MyPortfolioContext context = new MyPortfolioContext();      // db nesne örneği tanımlandı
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();           // Portfolios veritabanı sütunlarını liste olarak çağırdık ve döndürdük
            return View(values);
        }
    }
}
