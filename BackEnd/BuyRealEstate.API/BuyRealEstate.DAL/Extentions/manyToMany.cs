using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;

public static class ModelBuilderExtensions
{
    public static void ConfigureManyToMany<TJoin, TLeft, TRight>(
        this ModelBuilder modelBuilder,
        Expression<Func<TJoin, object>> joinKey,
        Expression<Func<TJoin, TLeft>> joinToLeft,
        Expression<Func<TLeft, IEnumerable<TJoin>>>? leftToJoins,
        Expression<Func<TJoin, TRight>> joinToRight,
        Expression<Func<TRight, IEnumerable<TJoin>>>? rightToJoins,
        Expression<Func<TJoin, object>> leftForeignKey,
        Expression<Func<TJoin, object>> rightForeignKey,
        DeleteBehavior deleteBehavior = DeleteBehavior.Restrict)
        where TJoin : class
        where TLeft : class
        where TRight : class
    {
        modelBuilder.Entity<TJoin>()
            .HasKey(joinKey); // Configure key for the join entity

        modelBuilder.Entity<TJoin>()
            .HasOne(joinToLeft)
            .WithMany(leftToJoins)
            .HasForeignKey(leftForeignKey)
            .OnDelete(deleteBehavior);

        modelBuilder.Entity<TJoin>()
            .HasOne(joinToRight)
            .WithMany(rightToJoins)
            .HasForeignKey(rightForeignKey)
            .OnDelete(deleteBehavior);
    }
}
