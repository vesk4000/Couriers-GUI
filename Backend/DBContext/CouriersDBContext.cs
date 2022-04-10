using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Couriers_GUI.Models
{
    public partial class CouriersDBContext : DbContext
    {
        public CouriersDBContext()
        {
        }

        public CouriersDBContext(DbContextOptions<CouriersDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Courier> Couriers { get; set; }
        public virtual DbSet<Dispatcher> Dispatchers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Recipient> Recipients { get; set; }
        public virtual DbSet<TypesOfService> TypesOfServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CouriersDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.AddressText, "UQ__Addresse__7D0C3F32E7613403")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Address");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.PhoneNumber }, "UQ__Clients__FB2A3015210323E2")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Courier>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.PhoneNumber }, "UQ__Couriers__FB2A30157DC59618")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dispatcher>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.PhoneNumber }, "UQ__Dispatch__FB2A3015B7434F38")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CourierId).HasColumnName("CourierID");

                entity.Property(e => e.DispatcherId).HasColumnName("DispatcherID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.ReceiveDate).HasColumnType("date");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK__Orders__AddressI__35BCFE0A");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__Orders__ClientID__38996AB5");

                entity.HasOne(d => d.Courier)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CourierId)
                    .HasConstraintName("FK__Orders__CourierI__398D8EEE");

                entity.HasOne(d => d.Dispatcher)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DispatcherId)
                    .HasConstraintName("FK__Orders__Dispatch__37A5467C");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RecipientId)
                    .HasConstraintName("FK__Orders__Recipien__3A81B327");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Orders__TypeID__36B12243");
            });

            modelBuilder.Entity<Recipient>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Recipien__737584F64D10704C")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypesOfService>(entity =>
            {
                entity.ToTable("TypesOfService");

                entity.HasIndex(e => e.Type, "UQ__TypesOfS__F9B8A48B5B6CEEDD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
