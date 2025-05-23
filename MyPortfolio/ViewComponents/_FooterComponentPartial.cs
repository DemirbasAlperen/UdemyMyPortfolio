using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent         // footer için tanımlanan component
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
