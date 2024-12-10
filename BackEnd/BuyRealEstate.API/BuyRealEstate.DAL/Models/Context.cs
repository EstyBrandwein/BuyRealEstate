using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
//using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using BuyRealEstate.Domain;
//using System.Configuration;


//public class AppDbContext : DbContext
//{
//    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//    {
//    }
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Users> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Plot> Plots { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Professional> Professionals { get; set; }
    public DbSet<DevelopmentStatus> DevelopmentStatuses { get; set; }
    public DbSet<LegalStatus> LegalStatuses { get; set; }
    public DbSet<PaymentStatus> PaymentStatuses { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<PaymentExecutionMethod> PaymentExecutionMethods { get; set; }
    public DbSet<RelationshipCustomersPlots> CustomerPlots { get; set; }
    public DbSet<RelationshipPaymentsPlots> PlotPayments { get; set; }
    public DbSet<RelationshipPaymentsProjects> ProjectPayments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Many-to-Many Relationship: User <-> Plot via RelationshipCustomersPlots
        modelBuilder.Entity<RelationshipCustomersPlots>()
            .HasKey(cp => cp.ID); // Define composite key (if needed, or let EF handle it)
        modelBuilder.Entity<RelationshipCustomersPlots>()
            .HasOne(cp => cp.User)  // RelationshipCustomersPlots has one User
            .WithMany(u => u.CustomerPlots)  // A User can have many CustomerPlots
            .HasForeignKey(cp => cp.UserID)  // Foreign Key in RelationshipCustomersPlots
                                .OnDelete(DeleteBehavior.Restrict); // Change from Cascade to Restrict

        modelBuilder.Entity<RelationshipCustomersPlots>()
            .HasOne(cp => cp.Plot)  // RelationshipCustomersPlots has one Plot
            .WithMany(p => p.CustomerPlots)  // A Plot can have many CustomerPlots
            .HasForeignKey(cp => cp.PlotID)
                                    .OnDelete(DeleteBehavior.Restrict); // Change from Cascade to Restrict
        
        // PlotPayment (Many-to-Many)
        modelBuilder.Entity<RelationshipPaymentsPlots>()
            .HasKey(pp => pp.ID);
        modelBuilder.Entity<RelationshipPaymentsPlots>()
            .HasOne(pp => pp.plot)
            .WithMany(p => p.PaymentPlots)
            .HasForeignKey(pp => pp.PlotID)
                                    .OnDelete(DeleteBehavior.Restrict); // Change from Cascade to Restrict
        
        modelBuilder.Entity<RelationshipPaymentsPlots>()
            .HasOne(pp => pp.payment)
            .WithMany(p => p.PaymentPlots)
            .HasForeignKey(pp => pp.PaymentID)
                                    .OnDelete(DeleteBehavior.Restrict); // Change from Cascade to Restrict

        //ProjectPayment(Many - to - Many)
        modelBuilder.Entity<RelationshipPaymentsProjects>()
            .HasKey(pp => pp.ID);
            // .OnDelete(DeleteBehavior.Restrict); // Change from Cascade to Restrict
        
        modelBuilder.Entity<RelationshipPaymentsProjects>()
            .HasOne(pp => pp.project)
            .WithMany(p => p.PaymentProject)
            .HasForeignKey(pp => pp.ProjectID)
                        .OnDelete(DeleteBehavior.Restrict); // Change from Cascade to Restrict
        ;
        modelBuilder.Entity<RelationshipPaymentsProjects>()
            .HasOne(pp => pp.payment)
            .WithMany(p => p.PaymentProject)
            .HasForeignKey(pp => pp.PaymentID)
                        .OnDelete(DeleteBehavior.Restrict); // Change from Cascade to Restrict
        ;
        //Plot->Project(One - to - Many)

        modelBuilder.Entity<Plot>()
     .HasOne(p => p.Project)
     .WithMany(pr => pr.Plots)
     .HasForeignKey(p => p.ProjectId); // Ensure this foreign key matches the primary key type
        // Image -> Project (One-to-Many)
        modelBuilder.Entity<Image>()
     .HasOne(img => img.Project)
     .WithMany(pr => pr.Images)
     .HasForeignKey(img => img.ProjectID);
        // Document -> Project (One-to-Many)
        modelBuilder.Entity<Document>()
            .HasOne(doc => doc.Project)
            .WithMany(pr => pr.Documents)
            .HasForeignKey(doc => doc.ProjectID);
        // Document -> Payments (One-to-Many)
        modelBuilder.Entity<Document>()
                  .HasOne(doc => doc.Payment)
                  .WithMany(pr => pr.PaymentConfirmation)
                  .HasForeignKey(doc => doc.PamentID);
        // DevelopStatus -> Project (One-to-Many)
        modelBuilder.Entity<DevelopmentStatus>()
                  .HasOne(doc => doc.Project)
                  .WithMany(pr => pr.DeveloperStatus)
                  .HasForeignKey(doc => doc.ProjectID);
        // LegalStatus -> Project (One-to-Many)
        modelBuilder.Entity<LegalStatus>()
                  .HasOne(doc => doc.Project)
                  .WithMany(pr => pr.LegalStatus)
                  .HasForeignKey(doc => doc.ProjectID);
        // PaymentStatus -> Payment (One-to-Many)
        modelBuilder.Entity<PaymentStatus>()
                  .HasOne(doc => doc.Payment)
                  .WithMany(pr => pr.PaymentStatus)
                  .HasForeignKey(doc => doc.PaymentId);
        //PaymentEx  -> Payment (One-to-Many)
        modelBuilder.Entity<PaymentExecutionMethod>()
                  .HasOne(doc => doc.Payment)
                  .WithMany(pr => pr.PaymentExecutionMethod)
                  .HasForeignKey(doc => doc.PaymentExecutionMethodID);
        //Documennst  -> Users (One-to-Many)
        modelBuilder.Entity<Document>()
                  .HasOne(doc => doc.User)
                  .WithMany(pr => pr.Documents)
                  .HasForeignKey(doc => doc.UserId);
        // Payment -> Professional (One-to-Many)
        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Professional) // Each Payment has one Professional
            .WithMany(pr => pr.Payments) // A Professional can have many Payments
            .HasForeignKey(p => p.ProfessionalId);// The foreign key in Payment
        base.OnModelCreating(modelBuilder);
    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        //string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionStrings;

    //        optionsBuilder.ConfigureWarnings(warnings =>
    //            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    //        //optionsBuilder.UseSqlServer("Server=buyrealestatedb.c1i0c2q8aofb.eu-north-1.rds.amazonaws.com,1433;Database = BuyRealEstateDB_Dev;User Id=BuyRAdmin;Password=liknot_nadlan;TrustServerCertificate=True;");
    //        optionsBuilder.UseSqlServer();
    //    }

    //}
}