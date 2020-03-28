using Microsoft.EntityFrameworkCore;

namespace GoalDiggerAPI.Models
{
    public class GoalDiggerContext : DbContext
    {
        public GoalDiggerContext(DbContextOptions<GoalDiggerContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}