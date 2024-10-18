using Microsoft.EntityFrameworkCore;
using ST10026525.PROG62112.POE.part1.Models;

namespace ST10026525.PROG62112.POE.part1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

       public DbSet <Claims> claims { get; set; }
        DbSet<Lecturer> Lecturers { get; set; }
        DbSet<Manager> Managers { get; set; }
    }
}
