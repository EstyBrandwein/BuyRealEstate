using BuyRealEstate.Domain.Extentions;
using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Linq.Expressions;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
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

        modelBuilder.ConfigureManyToMany<RelationshipCustomersPlots, User, Plot>(joinKey: cp => cp.ID, joinToLeft: cp => cp.User,
       leftToJoins: u => u.CustomerPlots, joinToRight: cp => cp.Plot, rightToJoins: p => p.CustomerPlots, leftForeignKey: cp => cp.UserID, rightForeignKey: cp => cp.PlotID);

        // Plot <-> Payment
        modelBuilder.ConfigureManyToMany<RelationshipPaymentsPlots, Plot, Payment>(joinKey: pp => pp.ID,joinToLeft: pp => pp.plot,leftToJoins: p => p.PaymentPlots,
            joinToRight: pp => pp.payment,rightToJoins: p => p.PaymentPlots, leftForeignKey: pp => pp.PlotID,rightForeignKey: pp => pp.PaymentID);

        // Project <-> Payment
        modelBuilder.ConfigureManyToMany<RelationshipPaymentsProjects, Project, Payment>(joinKey: pp => pp.ID,joinToLeft: pp => pp.project,leftToJoins: p => p.PaymentProject,
            joinToRight: pp => pp.payment, rightToJoins: p => p.PaymentProject,leftForeignKey: pp => pp.ProjectID, rightForeignKey: pp => pp.PaymentID);

        // Plot -> Project (One-to-Many)
        ConfigureOneToMany<Project, Plot>(modelBuilder,child => child.Project, parent => parent.Plots,child => child.ProjectId);
        // Image -> Project (One-to-Many)
        ConfigureOneToMany<Project, Image>(modelBuilder,child => child.Project,parent => parent.Images,child => child.ProjectID );

        // Document -> Project (One-to-Many)
        ConfigureOneToMany<Project, Document>(modelBuilder,child => child.Project,parent => parent.Documents,child => child.ProjectID);

        // Document -> Payment (One-to-Many)
        ConfigureOneToMany<Payment, Document>(modelBuilder,child => child.Payment,parent => parent.PaymentConfirmation,child => child.PamentID);

        // DevelopStatus -> Project (One-to-Many)
        ConfigureOneToMany<LegalStatus, Project>(modelBuilder,child => child.LegalStatus,parent => parent.Projects,child => child.LegalStatusId );

        // PaymentStatus -> Payment (One-to-Many)
        ConfigureOneToMany<PaymentStatus, Payment>(modelBuilder,child => child.PaymentStatus,parent => parent.Payments,child => child.PaymentStatusId);

        // PaymentExecutionMethod -> Payment (One-to-Many)
        ConfigureOneToMany<PaymentExecutionMethod, Payment>(modelBuilder,child => child.PaymentExecutionMethod,parent => parent.Payment,child => child.PaymentExecutionMethodID );

        // Document -> User (One-to-Many)
        ConfigureOneToMany<User, Document>(modelBuilder,child => child.User,parent => parent.Documents,child => child.UserId);
        // Payment -> Professional (One-to-Many)
        ConfigureOneToMany<Professional, Payment>( modelBuilder,child => child.Professional,parent => parent.Payments,child => child.ProfessionalId );
        ConfigureOneToMany<DevelopmentStatus, Project>(modelBuilder, c => c.DeveloperStatus, p => p.Project, c => c.DeveloperStatusID);

       modelBuilder.SeedMockData();
        base.OnModelCreating(modelBuilder);
    }
    private static void ConfigureOneToMany<TParent, TChild>(
    ModelBuilder modelBuilder,
    Expression<Func<TChild, TParent>> navigationExpression,
    Expression<Func<TParent, IEnumerable<TChild>>> collectionExpression,
    Expression<Func<TChild, object>> foreignKeyExpression)
    where TParent : class
    where TChild : class
    {
        modelBuilder.Entity<TChild>()
            .HasOne(navigationExpression)
            .WithMany(collectionExpression)
            .HasForeignKey(foreignKeyExpression)
            .OnDelete(DeleteBehavior.Restrict); // Default behavior; adjust as needed
    }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

}