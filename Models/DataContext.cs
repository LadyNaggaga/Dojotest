using Microsoft.EntityFrameworkCore;

namespace TheWall.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property( e => e.Content).IsRequired();
            });
        }
        
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Message> Message { get; set; }
    }
}