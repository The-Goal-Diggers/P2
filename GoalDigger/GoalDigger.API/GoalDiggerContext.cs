using Microsoft.EntityFrameworkCore;
using GoalDigger.API.Models;

namespace GoalDigger.API.GoalDiggerDBContext
{
    public class GoalDiggerContext : DbContext
    {
        public GoalDiggerContext(DbContextOptions<GoalDiggerContext> options)
            : base(options)
        {
        }

        public DbSet<PostModel> Posts { get; set; }
    }
}


