using Microsoft.EntityFrameworkCore;
using PresseMots.Models;


namespace PresseMots.Models.Data
{
    public class PresseMotsDbContext : DbContext
    {
        public PresseMotsDbContext(){}

        public PresseMotsDbContext(DbContextOptions<PresseMotsDbContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<StoryTag> storyTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Ne pas supprimer!
            modelBuilder.SetEntityRelationships();
            modelBuilder.GenerateData();

            base.OnModelCreating(modelBuilder);
            #endregion
        }

    }
}
