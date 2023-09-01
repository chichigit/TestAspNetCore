using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestAspNetCore.Pages;

public partial class InsightTestContext : DbContext
{
    public InsightTestContext()
    {
    }

    public InsightTestContext(DbContextOptions<InsightTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Number> Numbers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:InsightConn");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Number>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Number");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Number1).HasColumnName("number");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
