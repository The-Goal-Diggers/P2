using Microsoft.EntityFrameworkCore;
using GoalDigger.Domain.Models;

namespace GoalDigger.DataStore.Databases
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
            // Set keys
            builder.Entity<PostModel>().HasKey(x => x.uid);
            builder.Entity<UserModel>().HasKey(x => x.uid);

            // Define entity relationships
            builder.Entity<UserModel>().HasMany(x => x.Posts).WithOne(x => x.User);

        }

        // builder.Entity<User>().HasData(new User[]
        // {
        //     new User() { UserId = 1, Name = "Bianca", Password = "bianca", Address = "Central 960"},
        // });

    }
}


