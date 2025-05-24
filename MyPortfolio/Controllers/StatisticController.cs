using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            // buradaki kodlar artık _DashboardStatisticComponentPartial içerisinde
            ViewBag.todo1 = context.ToDoLists.Count();    // Yapılacaklar sayısı
            ViewBag.exp1 = context.Experiences.Count();   // Deneyimlerin sayısı
            ViewBag.port1 = context.Portfolios.Count();   // Projelerin(portfolio) sayısı
            ViewBag.test1 = context.Testimonials.Count();  // Referans sayısı
            ViewBag.social1 = context.SocialMedias.Count();   // Sosyal medya sayısı

            // En güçlü yetenek
            var maxSkill = context.Skills.OrderByDescending(x => x.Value).FirstOrDefault();  // OrderByDescending kullanarak en büyükten küçüğe sıraladık ve en yüksek değere sahip skill'i bulduk
            ViewBag.skill1 = maxSkill != null ? maxSkill.Title : "Yetenek Yok";   // En yüksek değerin adını ViewBag e aktardık

            // En zayıf yetenek
            var minSkill = context.Skills.OrderBy(x => x.Value).FirstOrDefault();   // OrderBy kullanarak en küçükten büyüğe sıraladık ve en küçük değere sahip skill'i bulduk
            ViewBag.skill2 = minSkill != null ? minSkill.Title : "Yetenek yok";

            // Yeteneklerin ortalaması
            var averageSkill = context.Skills.Select(x => Convert.ToInt32(x.Value)).Average();
            ViewBag.skill3 = Math.Round(averageSkill, 2);    // Virgülden sonra 2 basamak

            return View();  
        }
    }
}
