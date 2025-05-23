using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext:DbContext              // Bağlantı sınıfı
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)     // override: ezme işlemi yani benim istediğim formatta olacak
        {
            optionsBuilder.UseSqlServer("Server=ALPEREN\\MSSQL2022;initial Catalog=MyPortfolioDb;User Id=sa;Password=54321;TrustServerCertificate=True");     // Sql bağlantı adresi
        }

        // Aşağıda C# dan Sql tarafına yansıtılacak olan tablolar(Entites içindeki tablolar) yazılacak
        public DbSet<About> Abouts { get; set; }      // Tamamında çoğul(Abouts) olan Sql de yalın(About) olan C# da olacak
        public DbSet<Contact> Contacts { get; set; }     // DbSet : Veritabanındaki bir tabloyu temsil eder. 
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
