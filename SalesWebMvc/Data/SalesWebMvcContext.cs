﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecords { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesRecord>()
                .HasOne(sr => sr.Seller)
                .WithMany(s => s.Sales)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
