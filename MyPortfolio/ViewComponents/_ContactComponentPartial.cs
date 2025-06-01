using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent         // contact(iletişim) için tanımlanan component
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.title = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.desc = context.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone1 = context.Contacts.Select(x => x.Phone1).FirstOrDefault();
            ViewBag.phone2 = context.Contacts.Select(x => x.Phone2).FirstOrDefault();
            ViewBag.email1 = context.Contacts.Select(x => x.Email1).FirstOrDefault();
            ViewBag.email2 = context.Contacts.Select(x => x.Email2).FirstOrDefault();
            ViewBag.adress = context.Contacts.Select(x => x.Address).FirstOrDefault();
            return View();
        }
    }
}
