using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TodoAPI.DB.Entities;

namespace TodoAPI.DB
{
    public class DataContext : DbContext
    {
        private IDbContextTransaction _transaction = null;
        public DataContext() { 
        }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }

        public virtual DbSet<Todo> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Todo>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.IsComplete).IsRequired();

            });
            //OnModelCreatingPartial(modelBuilder);
        }
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
