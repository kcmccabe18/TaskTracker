using Microsoft.EntityFrameworkCore;

namespace TaskTracker.Models
{
    public class TicketContext : DbContext
    {
        public DbSet<TicketModel> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\zakarie\source\repos\TaskTracker\TaskTracker.db");
    }
}
