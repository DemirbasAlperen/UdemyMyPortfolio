using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent          // head için tanımlanan component
    {
        public IViewComponentResult Invoke()     // back end işlemleri yapacağım zaman, burada tanımladığım metot tarafından bu işlemler tutulacak
        {
            return View();      // view döndürecek
        }
    }
}
