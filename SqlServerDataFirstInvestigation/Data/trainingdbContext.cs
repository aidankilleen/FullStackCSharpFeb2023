using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SqlServerDataFirstInvestigation.Models;

namespace SqlServerDataFirstInvestigation.Data
{
    public partial class trainingdbContext : DbContext
    {
        public trainingdbContext()
        {
        }

        public trainingdbContext(DbContextOptions<trainingdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Member> Members { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("connection string missing!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
