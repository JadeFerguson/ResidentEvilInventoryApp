using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ResidentEvilInventoryApp.Classes;

namespace ResidentEvilInventoryApp.Data
{
    public partial class InventoryContext : DbContext
    {
        public InventoryContext()
        {
        }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        public virtual DbSet<UserInventory> UserInventories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Inventory");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInventory>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserInve__1788CC4CEA803FC1");

                entity.ToTable("UserInventory");

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.Ammo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstAid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fuel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Herbs)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Misc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplements)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weapons)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
