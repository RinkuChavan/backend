using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace shop_web_api.Models
{
    public partial class ishopDbContext : DbContext
    {
        public ishopDbContext()
        {
        }

        public ishopDbContext(DbContextOptions<ishopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ishopDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__Login__1797D024F3B6CE02");

                entity.Property(e => e.Userid).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__ProductT__516F03B5BC564DC8");

                entity.Property(e => e.TypeId).ValueGeneratedNever();

                entity.Property(e => e.ProductType1)
                    .HasColumnName("ProductType")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6EDEB93D141");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductTitle)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Products__TypeId__36B12243");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ConfirmPassword)
                    .HasColumnName("Confirm Password")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Contact)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
