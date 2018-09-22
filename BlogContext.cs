using EfCoreMigrations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EfCoreMigrations
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blog.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Title = ".NET Core is awesome!",
                    Author = "Matjaž Mav",
                });

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "EF Core Migrations?",
                    Content = "Teams? Huh?",
                    BlogId = 1,
                },
                new Post
                {
                    Id = 2,
                    Title = "Generic REST controller?",
                    Content = "Woow...",
                    BlogId = 1,
                });
        }
    }
}