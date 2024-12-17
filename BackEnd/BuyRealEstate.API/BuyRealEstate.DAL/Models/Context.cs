using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
//using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Collections.Generic;
using System.Configuration;

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
        modelBuilder.Entity<Project>()
                  .HasOne(doc => doc.LegalStatus)
                  .WithMany(pr => pr.Project)
                  .HasForeignKey(doc => doc.LegalStatusId);
        // Project = > LegalStatus ->  (One-to-Many)
        modelBuilder.Entity<Project>()
                  .HasOne(doc => doc.LegalStatus)
                  .WithMany(pr => pr.Project)
                  .HasForeignKey(doc => doc.LegalStatusId);
        // PaymentStatus -> Payment (One-to-Many)
        modelBuilder.Entity<Payment>()
                  .HasOne(doc => doc.PaymentStatus)
                  .WithMany(pr => pr.Payment)
                  .HasForeignKey(doc => doc.PaymentStatusId);
        //PaymentEx  -> Payment (One-to-Many)
        modelBuilder.Entity<Payment>()
                  .HasOne(doc => doc.PaymentExecutionMethod)
                  .WithMany(pr => pr.Payment)
                  .HasForeignKey(doc => doc.PaymentExecutionMethodId);
        //Documennst  -> Users (One-to-Many)
        modelBuilder.Entity<Document>()
                  .HasOne(doc => doc.User)
                  .WithMany(pr => pr.Documents)
                  .HasForeignKey(doc => doc.UserId);
        // Payment -> Professional (One-to-Many)
        modelBuilder.Entity<Payment>()
            //.HasOne(p => p.Professional) // Each Payment has one Professional
            //.WithMany(pr => pr.Payments) // A Professional can have many Payments
            //.HasForeignKey(p => p.ProfessionalId);// The foreign key in Payment
        .HasOne(p => p.Professional) // Each Payment has one Professional
.WithMany(pr => pr.Payments) // A Professional can have many Payments
.HasForeignKey(p => p.ProfessionalId);



        modelBuilder.Entity<DevelopmentStatus>().HasData(
               new DevelopmentStatus { Status = "הפיתוח בעיצומו", Id = 1 },
               new DevelopmentStatus { Status = "הפיתוח הושלם", Id = 2 }
             );
        modelBuilder.Entity<Document>().HasData(
           new Document { ID = 1, FileType = ".pdf", ProjectID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, DocumentDescription = "תעודת זהות", DocumentData = File.ReadAllBytes("D:\\Users\\programmer\\Downloads\\הסכם הלוואה מלווה לקנות ופרידמן.docx") },
           new Document { ID = 2, FileType = ".pdf", PamentID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, DocumentDescription = "תעודת זהות", DocumentData = File.ReadAllBytes("D:\\Users\\programmer\\Downloads\\מסמך-אפיון-לקנות נדלן (1) (2).docx") }

            );

        modelBuilder.Entity<Image>().HasData(
           new Image { ID = 1, FileType = ".jpg", ProjectID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, ImageDescription = "תמונה", ImageData = File.ReadAllBytes("D:\\Users\\programmer\\Downloads\\הסכם הלוואה מלווה לקנות ופרידמן.docx") },
           new Image { ID = 2, FileType = ".jpg", ProjectID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, State = true, InsertUser = 1, UpdateUser = 1, ImageDescription = "תמונה", ImageData = File.ReadAllBytes("D:\\Users\\programmer\\Downloads\\הסכם הלוואה מלווה לקנות ופרידמן.docx") }
            );
        modelBuilder.Entity<LegalStatus>().HasData(
            new LegalStatus { Id = 1, Status = "בשלבי רכישה", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
            new LegalStatus { Id = 2, Status = "הושלמה על שם הנאמן", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
            new LegalStatus { Id = 3, Status = "בתהליכי רישום ברשות המיסים", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
            new LegalStatus { Id = 4, Status = "העסקה רשומה על שימכם", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
            );
        modelBuilder.Entity<Payment>().HasData(
            new Payment { ID = 1,PaymentStatusId = 1, Amount = 360000, PaymentExecutionMethodId = 1, Component = "רשות המיסים", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, LastPaymentDate = DateTime.Now, State = true }
            );
        modelBuilder.Entity<PaymentExecutionMethod>().HasData(
           new PaymentExecutionMethod { ID = 1, Description = "אשראי", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new PaymentExecutionMethod { ID = 2, Description = "העברה בנקאית", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new PaymentExecutionMethod { ID = 3, Description = "ציק", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new PaymentExecutionMethod { ID = 4, Description = "מזומן", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
        );
        modelBuilder.Entity<PaymentStatus>().HasData(
            new PaymentStatus { Id = 1, Status = "לא שולם", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
            new PaymentStatus { Id = 2, Status = "מחכה לאישור", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
            new PaymentStatus { Id = 3, Status = "שולם", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
        );
        modelBuilder.Entity<Permission>().HasData(
           new Permission { Id = 5, permission = "מנהל", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new Permission { Id = 6, permission = "מזכירה", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new Permission { Id = 7, permission = "לקוח", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new Permission { Id = 8, permission = "איש קשר", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
      );
        modelBuilder.Entity<Plot>().HasData(
           new Plot { ID = 1, PlotCost = 580000, MonthlyFundingCost = 10000, MonthsForFundingCost = 10, PlotValue = 600000, PlotSize = 120, PlotNumber = 12, ProjectId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new Plot { ID = 2, PlotCost = 580000, MonthlyFundingCost = 10000, MonthsForFundingCost = 10, PlotValue = 600000, PlotSize = 138, PlotNumber = 11, ProjectId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
           new Plot { ID = 3, PlotCost = 580000, MonthlyFundingCost = 10000, MonthsForFundingCost = 10, PlotValue = 600000, PlotSize = 110, PlotNumber = 13, ProjectId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
      );
        //modelBuilder.Entity<Professional>().HasData(
        //   new Professional { ID = 4, FirstName = "רשות", LastName = "המיסים", Email = "ghj@hjj", Password = "123456", Phone = "050141155", PermissionId = 4, Username = "רשות המיסים", Professtion = "מיסים", WebsiteAddress = "https://www.efshar-nadlan.co.il", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true },
        //   new Professional { ID = 5, FirstName = "רועי", LastName = "גרילק", Email = "royi@grilak", Password = "123456", Phone = "0556565626", PermissionId = 4, Username = "עורך דין", Professtion = "עריכת דין", InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
        //  );
        modelBuilder.Entity<Project>().HasData(
           new Project { ID = 1, ProjectName = "כרמית 11", ProjectAddress = "כרמית", LegalStatusId = 1, ProjectManagerID = 1, DeveloperStatusID = 1, GrossProfit = 12000, LinkToLead2 = "https://www.efshar-nadlan.co.il/", ProjectType = true, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }

            );
        modelBuilder.Entity<RelationshipCustomersPlots>().HasData(
           new RelationshipCustomersPlots { ID = 1, PlotID = 1, UserID = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
            );
        modelBuilder.Entity<RelationshipPaymentsPlots>().HasData(
           new RelationshipPaymentsPlots { ID = 1, PlotID = 1, PaymentID = 1, paymentStutusId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
            );
        modelBuilder.Entity<RelationshipPaymentsProjects>().HasData(
           new RelationshipPaymentsProjects { ID = 1, ProjectID = 1, PaymentID = 1, paymentStutusId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
            );
        modelBuilder.Entity<Users>().HasData(
            new Users { ID = 1, FirstName = "חיה", LastName = "ברנדויין", Email = "chayamalot@gmail.com", Password = "CB5328152", Phone = "0504101585", Username = "ChayaB", PermissionId = 1, InsertDate = DateTime.Now, UpdateDate = DateTime.Now, InsertUser = 1, UpdateUser = 1, State = true }
            );




        base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

}