﻿using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Persistence
{
    public class MovieDbContext(DbContextOptions<MovieDbContext> options): DbContext(options)
    {
        public DbSet<Movie> Movies => Set<Movie>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("app");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
