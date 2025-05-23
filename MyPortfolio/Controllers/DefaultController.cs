using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class DefaultController : Controller        // UI için controller
    {
        public IActionResult Index()   // IActionResult türü bana view döndürmemi sağlar. Index; motod ismi
        {
            return View();
        }
    }
}
