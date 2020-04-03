using Microsoft.EntityFrameworkCore;
using GoalDigger.Domain.Models;

namespace GoalDigger.Datastore.Databases
{
    public class GoalDiggerDBContext : DbContext
    {
        // public DbSet<Pizza> Pizza { get; set; }
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<UserModel> Users { get; set; }
        // public DbSet<User> User { get; set; }
        public GoalDiggerDBContext(DbContextOptions<GoalDiggerDBContext> options)
            : base(options) {}

        

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<PostModel>().HasKey(u => u.UserId);

            // builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);

        }

        // builder.Entity<User>().HasData(new User[]
        // {
        //     new User() { UserId = 1, Name = "Bianca", Password = "bianca", Address = "Central 960"},
        // });
}


