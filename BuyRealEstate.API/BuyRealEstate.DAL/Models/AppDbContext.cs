using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.DAL.Models
{
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet for each table
        public DbSet<LegalStatus> LegalStatuses { get; set; }
        public DbSet<DevelopmentStatus> DevelopmentStatuses { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<UserField> UsersToFields { get; set; }
        public DbSet<FieldPayment> FieldsToPayments { get; set; }
        public DbSet<PaymentProject> PaymentsToProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships for many-to-many tables if necessary
            modelBuilder.Entity<UserField>()
                .HasOne(uf => uf.User)
                .WithMany()
                .HasForeignKey(uf => uf.UserID);

            modelBuilder.Entity<UserField>()
                .HasOne(uf => uf.Field)
                .WithMany()
                .HasForeignKey(uf => uf.FieldID);

            modelBuilder.Entity<FieldPayment>()
                .HasOne(fp => fp.Field)
                .WithMany()
                .HasForeignKey(fp => fp.FieldID);

            modelBuilder.Entity<FieldPayment>()
                .HasOne(fp => fp.Payment)
                .WithMany()
                .HasForeignKey(fp => fp.PaymentID);

            modelBuilder.Entity<FieldPayment>()
                .HasOne(fp => fp.PaymentStatus)
                .WithMany()
                .HasForeignKey(fp => fp.PaymentStatusID);

            modelBuilder.Entity<PaymentProject>()
                .HasOne(pp => pp.Payment)
                .WithMany()
                .HasForeignKey(pp => pp.PaymentID);

            modelBuilder.Entity<PaymentProject>()
                .HasOne(pp => pp.Project)
                .WithMany()
                .HasForeignKey(pp => pp.ProjectID);

            modelBuilder.Entity<PaymentProject>()
                .HasOne(pp => pp.PaymentStatus)
                .WithMany()
                .HasForeignKey(pp => pp.PaymentStatusID);
        }
    }

}
