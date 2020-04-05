// using Microsoft.EntityFrameworkCore;
// using GoalDigger.Domain.Models;

// namespace GoalDigger.DataStore.Databases
// {
//     public class GoalDiggerDBContext : DbContext
//     {
//         public DbSet<PostModel> Posts { get; set; }
//         public DbSet<UserModel> Users { get; set; }

//         public GoalDiggerDBContext(DbContextOptions<GoalDiggerDBContext> options)
//             : base(options) {}


//         protected override void OnModelCreating(ModelBuilder builder) 
//         {
//             // Set keys
//             builder.Entity<PostModel>().HasKey(x => x.uid);
//             builder.Entity<UserModel>().HasKey(x => x.uid);

//             // Define entity relationships
//             builder.Entity<UserModel>().HasMany(x => x.Posts).WithOne(x => x.User);

//             // Input dummy data
//             builder.Entity<UserModel>().HasData(new UserModel[]
//             {
//                 new UserModel() { UserName = "Alex1234" },
//             });

//         }

        

//     }
// }


