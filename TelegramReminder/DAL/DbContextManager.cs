using Microsoft.EntityFrameworkCore;

namespace TelegramReminder
{
    public class DbContextManager : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<CurrentState> CurrentStates { get; set; }

        public DbContextManager(DbContextOptions<DbContextManager> options)
            : base(options)
        {
        }
    }
}
