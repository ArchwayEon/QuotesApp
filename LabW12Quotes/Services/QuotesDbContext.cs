using LabW12Quotes.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabW12Quotes.Services
{
   public class QuotesDbContext : DbContext
   {
      public QuotesDbContext(DbContextOptions options) : base(options)
      {
      }

      public DbSet<Quote> Quotes { get; set; }
   }
}
