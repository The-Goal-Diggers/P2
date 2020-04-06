using Microsoft.EntityFrameworkCore;
using GoalDigger.Domain.Models;

namespace GoalDigger.DataStore.Databases
{
    public class GoalDiggerDBContext : DbContext
    {
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<GoalModel> Goals { get; set; }
        public DbSet<FeedModel> Feeds { get; set; }
        public DbSet<FeedPostModel> FeedPosts { get; set; }
        public DbSet<MentionModel> Mentions { get; set; }
        public DbSet<HashtagPostModel> HashtagPosts { get; set; }
        public DbSet<HashtagModel> Hashtags { get; set; }
        public GoalDiggerDBContext(/*DbContextOptions<GoalDiggerDBContext> options*/){}
            // : base(options) {}


        protected override void OnModelCreating(ModelBuilder builder) 
        {
            // Set keys
            builder.Entity<PostModel>().HasKey(x => x.uid);
            builder.Entity<UserModel>().HasKey(x => x.uid);
            builder.Entity<GoalModel>().HasKey(x => x.uid);
            builder.Entity<FeedModel>().HasKey(x => x.uid);
            builder.Entity<FeedPostModel>().HasKey(x => x.uid);
            builder.Entity<MentionModel>().HasKey(x => x.uid);
            builder.Entity<HashtagPostModel>().HasKey(x => x.uid);
            builder.Entity<HashtagModel>().HasKey(x => x.uid);


            // Define entity relationships
            builder.Entity<UserModel>().HasMany(x => x.Posts).WithOne(x => x.User);
            builder.Entity<UserModel>().HasMany(x => x.Goals).WithOne(x => x.User);
            builder.Entity<UserModel>().HasOne(x => x.Feed).WithOne(x => x.User);
            builder.Entity<UserModel>().HasOne(x => x.Mention).WithOne(x => x.User); // change to many-to-many or many-to-one????
            builder.Entity<FeedPostModel>().HasMany(x => x.Feeds).WithOne(x => x.FeedPost);
            builder.Entity<FeedPostModel>().HasMany(x => x.Posts).WithOne(x => x.FeedPost);
            builder.Entity<PostModel>().HasMany(x => x.Mentions).WithOne(x => x.Post);
            builder.Entity<HashtagPostModel>().HasMany(x => x.Posts).WithOne(x => x.HashtagPost);
            builder.Entity<HashtagPostModel>().HasMany(x => x.Hashtags).WithOne(x => x.HashtagPost);
            

            // Input dummy data
            builder.Entity<UserModel>().HasData(new UserModel[]
            {
                new UserModel() { UserName = "Alex1234" },
            });
            builder.Entity<PostModel>().HasData(new PostModel[]
            {
                new PostModel() { Body = "My first #goal !!!" },
                new PostModel() { Body = "My second #goal !!!" },
            });

        }

        

    }
}


