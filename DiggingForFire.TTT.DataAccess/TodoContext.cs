using System.Reflection;
using DiggingForFire.TTT.Domain;
using Microsoft.EntityFrameworkCore;

namespace DiggingForFire.TTT.DataAccess
{
    public class TodoContext : DbContext, ITodoContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            
        }
        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
