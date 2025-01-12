﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Roughcut.Atlassian.DataStorage.DbModels;
using Microsoft.EntityFrameworkCore;
using Roughcut.Atlassian.Interfaces.AppConfig;

namespace Roughcut.Atlassian.DataStorage.DbContexts;

public partial class JiraDbContext : DbContext
{
    public JiraDbContext()
    {
    }

    public JiraDbContext(DbContextOptions<JiraDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ThisWorks> ThisWorks { get; set; }

    // jira models
    public virtual DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(ConnectionStrings.JiraDbConnString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP437_CI_AI");

        modelBuilder.Entity<ThisWorks>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}