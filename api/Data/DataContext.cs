using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {}

    public DbSet<Hero> Heroes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Like> Likes { get; set; }
  }
}