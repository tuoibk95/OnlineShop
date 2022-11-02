using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext() : base("name=OnlineShopDbContext")
        {
        }

        public virtual DbSet<mst_group> mst_group { get; set; }
        public virtual DbSet<mst_japan> mst_japan { get; set; }
        public virtual DbSet<tbl_detail_user_japan> tbl_detail_user_japan { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mst_group>()
                .HasMany(e => e.tbl_user)
                .WithRequired(e => e.mst_group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<mst_japan>()
                .HasMany(e => e.tbl_detail_user_japan)
                .WithRequired(e => e.mst_japan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_detail_user_japan)
                .WithRequired(e => e.tbl_user)
                .WillCascadeOnDelete(false);
        }
    }
}
