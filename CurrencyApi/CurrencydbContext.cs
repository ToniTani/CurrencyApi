﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CurrencyApi.Models;

namespace CurrencyApi
{
    public partial class CurrencydbContext : DbContext
    {
        public CurrencydbContext()
        {
        }

        public CurrencydbContext(DbContextOptions<CurrencydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RATE> RATE { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}