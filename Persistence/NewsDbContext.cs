using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Api.Models;
using System.Collections.Generic;
using System.IO;

namespace Api.Persistence
{
    public class NewsDbContext:DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(SeedData());
        }
        public List<Article> SeedData()
        {
            var articles = new List<Article>();
            using (StreamReader r = new StreamReader(@"Seeder\articles.json"))
            {
                string json = r.ReadToEnd();
                articles = JsonConvert.DeserializeObject<List<Article>>(json);
            }
            return articles;
        }
    }
}
