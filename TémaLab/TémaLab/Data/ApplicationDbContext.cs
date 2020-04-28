using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TémaLab.Data.Entities;
using TémaLab.Data.EntityConfiguration;
using TémaLab.Data.SeedInterfaces.SeedService;
using TémaLab.Data.SeedService;

namespace TémaLab.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private readonly ISeedService _seedService;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ISeedService seedService) : base(options) => _seedService = seedService;

        //public override DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Friendship> Friendship { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventParticipation> EventParticipations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
            
            modelBuilder.Entity<Friendship>().HasKey(f => new { f.User1Id, f.User2Id });

            modelBuilder.Entity<Friendship>()
              .HasOne(f => f.User1)
              .WithMany(u => u.Friendships1)
              .HasForeignKey(f => f.User1Id)
              .Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.User2)
                .WithMany(u => u.Friendships2)
                .HasForeignKey(f => f.User2Id)
                .Metadata.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new CompetitionEntityConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new CommentEntitiyConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new EventEntityConfiguration(_seedService));
        }
    }
}
