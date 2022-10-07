using Microsoft.EntityFrameworkCore;

namespace DesafioTM.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> option) : base(option) {}

        public DbSet<Event> Events { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<Ticket_Event> Ticket_Events { get; set; }
    }
}
