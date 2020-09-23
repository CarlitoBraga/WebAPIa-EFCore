using Microsoft.EntityFrameworkCore;
using WebAPISqlite.Model;

namespace WebAPISqlite.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options) {}
         public DbSet<Produtos> Produtos { get; set; }
         
         
    }
}