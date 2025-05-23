using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent       // testimonial için tanımlanan component
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
