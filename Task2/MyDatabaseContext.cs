using Microsoft.EntityFrameworkCore;

namespace Task2
{
    internal class MyDatabaseContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Userbase;Trusted_Connection=True;");
        }
    }
}
