
﻿using BuyRealEstate.Domain.Extensions;
using BuyRealEstate.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
//using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System.Collections.Generic;
using System.Configuration;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BuyRealEstate.DAL.Models
{


    public class BuyRealEstateDbContext : DbContext
    {

    
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
    public DbSet<Professional> professionals { get; set; }
    public DbSet<PaymentExecutionMethod> PaymentExecutionMethods { get; set; }
    public DbSet<RelationshipCustomersPlots> CustomerPlots { get; set; }
    public DbSet<RelationshipPaymentsPlots> PlotPayments { get; set; }
    public DbSet<RelationshipPaymentsProjects> ProjectPayments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        AddManyToMany<RelationshipCustomersPlots, Users, Plot>(modelBuilder, cp => cp.ID, cp => cp.User,
        cp => cp.Plot, u => u.CustomerPlots, p => p.CustomerPlots, cp => cp.UserID, cp => cp.PlotID);

        // Plot <-> Payment via RelationshipPaymentsPlots
        AddManyToMany<RelationshipPaymentsPlots, Plot, Payment>(modelBuilder, pp => pp.ID, pp => pp.plot,
            pp => pp.payment, p => p.PaymentPlots, p => p.PaymentPlots, pp => pp.PlotID, pp => pp.PaymentID);

        // Project <-> Payment via RelationshipPaymentsProjects
        AddManyToMany<RelationshipPaymentsProjects, Project, Payment>(modelBuilder, pp => pp.ID, pp => pp.project,
            pp => pp.payment, p => p.PaymentProject, p => p.PaymentProject, pp => pp.ProjectID, pp => pp.PaymentID);

        AddOneToMany<Plot, Project>(modelBuilder, p => p.Project, p => p.ProjectId, p => p.Plots);
        AddOneToMany<Image, Project>(modelBuilder, i => i.Project, i => i.ProjectID, i => i.Images);
        AddOneToMany<Document, Project>(modelBuilder, d => d.Project, d => d.ProjectID, d => d.Documents);
        AddOneToMany<Document, Payment>(modelBuilder, d => d.Payment, d => d.PamentID, d => d.PaymentConfirmation);
        AddOneToMany<Project, DevelopmentStatus>(modelBuilder, p => p.DeveloperStatus, p => p.DeveloperStatusID, p => p.Project);
        AddOneToMany<Project, LegalStatus>(modelBuilder, p => p.LegalStatus, p => p.LegalStatusId, p => p.Project);
        AddOneToMany<Payment, PaymentStatus>(modelBuilder, p => p.PaymentStatus, p => p.PaymentStatusId, p => p.Payment);
        AddOneToMany<Payment, PaymentExecutionMethod>(modelBuilder, doc => doc.PaymentExecutionMethod, doc => doc.PaymentExecutionMethodId, pr => pr.Payment);
        AddOneToMany<Document, Users>(modelBuilder, doc => doc.User, doc => doc.UserId, pr => pr.Documents);
        AddOneToMany<Users, Permission>(modelBuilder, p => p.Permission, p => p.PermissionId, p => p.users);
        //AddOneToMany<Professional, Permission>(modelBuilder, p => p.Permission, p => p.PermissionId, p => p.Professional);
        // Payment -> Professional (One-to-Many)
        modelBuilder.Entity<Payment>()
                  .HasOne(p => p.Professional) // Each Payment has one Professional
                    .WithMany(pr => pr.Payments) // A Professional can have many Payments
                    .HasForeignKey(p => p.ProfessionalId);

      // modelBuilder.AddMockData();
        base.OnModelCreating(modelBuilder);
    }

    private void AddOneToMany<TEntity, TRelatedEntity>(
    ModelBuilder modelBuilder,
    Expression<Func<TEntity, TRelatedEntity>> navigationProperty,
    Expression<Func<TEntity, object?>> foreignKeyProperty,
    Expression<Func<TRelatedEntity, IEnumerable<TEntity>?>>? relatedNavigationProperty)
    where TEntity : class
    where TRelatedEntity : class
    {
        modelBuilder.Entity<TEntity>()
            .HasOne(navigationProperty)
            .WithMany(relatedNavigationProperty)
            .HasForeignKey(foreignKeyProperty);
    }
    private void AddManyToMany<TJoinEntity, TEntity, TRelatedEntity>(
    ModelBuilder modelBuilder,
    Expression<Func<TJoinEntity, object?>> keyProperty,
    Expression<Func<TJoinEntity, TEntity>> entityNavigation,
    Expression<Func<TJoinEntity, TRelatedEntity>> relatedEntityNavigation,
    Expression<Func<TEntity, IEnumerable<TJoinEntity>?>> entityCollection,
    Expression<Func<TRelatedEntity, IEnumerable<TJoinEntity>?>> relatedEntityCollection,
    Expression<Func<TJoinEntity, object?>> foreignKeyToEntity,
    Expression<Func<TJoinEntity, object?>> foreignKeyToRelatedEntity,
    DeleteBehavior deleteBehavior = DeleteBehavior.Restrict
)
    where TJoinEntity : class
    where TEntity : class
    where TRelatedEntity : class
    {
        modelBuilder.Entity<TJoinEntity>()
            .HasKey(keyProperty);

        modelBuilder.Entity<TJoinEntity>()
            .HasOne(entityNavigation)
            .WithMany(entityCollection)
            .HasForeignKey(foreignKeyToEntity)
            .OnDelete(deleteBehavior);

        modelBuilder.Entity<TJoinEntity>()
            .HasOne(relatedEntityNavigation)
            .WithMany(relatedEntityCollection)
            .HasForeignKey(foreignKeyToRelatedEntity)
            .OnDelete(deleteBehavior);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

}
