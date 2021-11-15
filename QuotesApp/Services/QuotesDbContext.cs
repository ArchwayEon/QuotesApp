using QuotesApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace QuotesApp.Services
{
   public class QuotesDbContext : DbContext
   {
      public QuotesDbContext(DbContextOptions options) : base(options)
      {
      }

      public DbSet<Quote> Quotes { get; set; }
   }
}
