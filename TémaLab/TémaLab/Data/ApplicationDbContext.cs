﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TémaLab.Data.Entities;

namespace TémaLab.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public override DbSet<IdentityUser> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Friendship> Friendship { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Participation> Participations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Friendship>().HasKey(f => new { f.User1Id, f.User2Id });
            modelBuilder.Entity<Friendship>()
              .HasOne(f => f.User1)
              .WithMany()
              .HasForeignKey(f => f.User1Id);

            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.User2)
                .WithMany()
                .HasForeignKey(f => f.User2Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
