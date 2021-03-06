﻿using TSTOneighboreenos.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TSTOneighboreenos.DAL
{
    public class NeighboreenoContext : DbContext
    {
        public NeighboreenoContext() : base("NeighboreenContext")
        {
        }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}