using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veic_web.Models.Data
{
    public class CarnumberDbContext : DbContext
    {
        public CarnumberDbContext(DbContextOptions<CarnumberDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            modelBuilder.Entity<Article>()
                        .HasOne(e => e.Type)
                        .WithMany(e => e.Articles)
                        .HasForeignKey(e => e.Type_id)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
