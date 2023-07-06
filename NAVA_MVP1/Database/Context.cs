using Microsoft.EntityFrameworkCore;
using NAVA_MVP1.Models;

namespace NAVA_MVP1.Database
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.ConnectionString);
        }


        public DbSet<Login> Login { get; set; }
        public DbSet<UsersModel> UsersModels { get; set; }
    }
}
