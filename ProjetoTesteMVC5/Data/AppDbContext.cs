﻿using ProjetoTesteMVC5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProjetoTesteMVC5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base ("DefaultConnection")
        {
                
        }

        public DbSet<Aluno> Alunos{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Aluno>().ToTable("Alunos");

            base.OnModelCreating(modelBuilder);
        }
    }
}