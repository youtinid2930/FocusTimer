using Microsoft.EntityFrameworkCore;
using FocusTimer.Models;


namespace FocusTimer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<PomodoroSession> PomodoroSessions { get; set; }
    }
}
