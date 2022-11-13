using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WatchOnline_.Models;

namespace WatchOnline_.Context
{
    public class WatchOnline_Context: DbContext
    {
        public WatchOnline_Context() : base("WatchOnline_ContextDB")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<User>()
                        .HasRequired(s => s.ShoppingCart)
                        .WithRequiredPrincipal(ad => ad.User);


            modelBuilder.Entity<Watch>()
                .HasMany<ShoppingCart>(s => s.ShoppingCarts)
                .WithMany(c => c.Watches)
                .Map(cs =>
                {
                    cs.MapLeftKey("WatchRefId");
                    cs.MapRightKey("ShoppingCartRefId");
                    cs.ToTable("WatchShoppingCart");
                });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Recommendation> Recommendations { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<Watch> Watches { get; set; }

    }
}