using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ValueAPI.Models;

namespace ValueAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Point> Points { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
