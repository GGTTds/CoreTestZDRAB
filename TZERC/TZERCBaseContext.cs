using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TZERC
{
    public partial class TZERCBaseContext : DbContext
    {
        public TZERCBaseContext()
        {
        }

        public TZERCBaseContext(DbContextOptions<TZERCBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataUser> DataUsers { get; set; }
        public virtual DbSet<Tarif> Tarifs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=WIN-TUD2DUAF5IN\\SQLEXPRESS;Database=TZERCBase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<DataUser>(entity =>
            {
                entity.ToTable("DataUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GvspodshLaterMount).HasColumnName("GVSpodshLaterMount");

                entity.HasOne(d => d.DataKeyNavigation)
                    .WithMany(p => p.DataUsers)
                    .HasForeignKey(d => d.DataKey)
                    .HasConstraintName("FK_DataUser_User");
            });

            modelBuilder.Entity<Tarif>(entity =>
            {
                entity.ToTable("Tarif");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EdIzm).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Tarif1).HasColumnName("Tarif");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(10);

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PriborGvs).HasColumnName("PriborGVS");

                entity.Property(e => e.PriborXvs).HasColumnName("PriborXVS");

                entity.Property(e => e.Surnsme)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
