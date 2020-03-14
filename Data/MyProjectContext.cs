using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data
{
    public class MyProjecContext : DbContext
    {
        public MyProjecContext(DbContextOptions<MyProjecContext> options)
            : base(options)
        {
        }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Products> Products { get; set; }
    }
}

