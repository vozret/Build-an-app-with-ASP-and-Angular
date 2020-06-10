using BabyApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BabyApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Like>()
                .HasKey(k => new {k.LikerId, k.LikeeId});

            // One likee is going to have many likers
            builder.Entity<Like>()
                .HasOne(u => u.Likee)
                .WithMany( u => u.Likers)
                .HasForeignKey(u => u.LikeeId)
                .OnDelete(DeleteBehavior.Restrict);
            
            // one liker is going to have many likees
            builder.Entity<Like>()
                .HasOne(u => u.Liker)
                .WithMany( u => u.Likees)
                .HasForeignKey(u => u.LikerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}