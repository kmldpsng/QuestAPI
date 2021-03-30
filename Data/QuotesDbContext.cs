using Microsoft.EntityFrameworkCore;
using QuestAPI.Model;

namespace QuestAPI.Data
{
    public class QuotesDbContext : DbContext
    {
        public QuotesDbContext(DbContextOptions<QuotesDbContext> options) : base(options)
        {

        }
        public DbSet<Quotes> Quotes { get; set; }
    }
}
