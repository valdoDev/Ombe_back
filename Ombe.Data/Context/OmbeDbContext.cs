using Microsoft.EntityFrameworkCore;
using Ombe.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ombe.Data.Context
{
    public class OmbeDbContext : DbContext
    {
        public OmbeDbContext(DbContextOptions<OmbeDbContext> options) : base(options) {
        }

        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Patern> Paterns { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<RatingInteraction> RatingInteractions { get; set; }
        public DbSet<RatingInteractionType> RatingInteractionTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Favorite>()
                .HasOne<Product>()
                .WithMany()
                .HasForeignKey(p => p.IdProduct);

            modelBuilder.Entity<Favorite>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(p => p.IdUser);




            modelBuilder.Entity<Rating>()
                .HasOne<Product>()
                .WithMany()
                .HasForeignKey(p => p.IdProduct);

            modelBuilder.Entity<Rating>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(p => p.IdUser);


            modelBuilder.Entity<RatingInteraction>()
              .HasOne<User>()
              .WithMany()
              .HasForeignKey(p => p.IdUserInteraction)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RatingInteraction>()
               .HasOne<Rating>()
               .WithMany()
               .HasForeignKey(p => p.IdRating);

            modelBuilder.Entity<RatingInteraction>()
               .HasOne<RatingInteractionType>()
               .WithMany()
               .HasForeignKey(p => p.IdRatingInteractionType);
              
         


             modelBuilder.Entity<User>()
                 .HasOne<Invite>()
                 .WithMany()
                 .HasForeignKey(p => p.IdInvite); 




              modelBuilder.Entity<Product>()
                 .HasMany(b => b.Paterns)
                 .WithOne();

        }

        public override int SaveChanges()
        {
            var now = DateTime.UtcNow;

            foreach (var changedEntity in ChangeTracker.Entries())
            {
                if (changedEntity.Entity is Entity entity)
                {
                    switch (changedEntity.State)
                    {
                        case EntityState.Added:
                            entity.CreatedAt = now;
                            entity.UpdatedAt = now;
                            entity.CreatedBy = "";
                            entity.UpdatedBy = "";
                            break;
                        case EntityState.Modified:
                            Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                            Entry(entity).Property(x => x.CreatedAt).IsModified = false;
                            entity.UpdatedAt = now;
                            entity.UpdatedBy = "";
                            break;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}
