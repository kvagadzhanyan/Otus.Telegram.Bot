using Microsoft.EntityFrameworkCore;

namespace TelegramReminder
{
    public class DbContextManager : DbContext
    {
        public DbContextManager(DbContextOptions<DbContextManager> options)
            : base(options)
        {
        }

        /*
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<UserState> UserStates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventType)
                .WithMany(et => et.Events)
                .HasForeignKey(e => e.EventTypeId);
        }
        */
    }
}
