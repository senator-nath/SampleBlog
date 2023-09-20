using Microsoft.EntityFrameworkCore;
using SampleBlog.Model;

namespace SampleBlog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /*protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.Entity<Comment>()
                .HasOne(u => u.UserId)
                .WithMany(o => o.Comments)
                .HasForeignKey(ui => ui.UserId)
                .IsRequired();

            Builder.Entity<Comment>()
                .HasOne(c => c.BlogPost)
                .WithMany(u => u.Comments)
                .HasForeignKey(ci => ci.BlogPostId)
                .IsRequired();

            Builder.Entity<BlogPost>()
                .HasOne(b => b.UserId)
                .WithMany(u => u.BlogPosts)
                .HasForeignKey(c => c.UserId)
                .IsRequired();

            Builder.Entity<BlogPostCategory>()
              .HasOne(c => c.BlogPost)
              .WithMany(u => u.BlogPostCategories)
              .HasForeignKey(c => c.BlogPostId)
              .IsRequired();

            Builder.Entity<BlogPostCategory>()
           .HasOne(c => c.Category)
           .WithMany(u => u.BlogPostCategories)
           .HasForeignKey(c => c.CategoryId)
           .IsRequired();
        }*/
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
