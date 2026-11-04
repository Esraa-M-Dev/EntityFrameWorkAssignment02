using EntityFrameWorkAssignment02.Configurations;
using EntityFrameWorkAssignment02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkAssignment02.Contexts
{
    internal class EventHubContext:DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }

        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Attendee> Attendees { get; set; }

        public DbSet<Badge> Badges { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ESRAA\\SQLEXPRESS01;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>(entity =>
            {
                entity.HasKey(p => p.OrganizerProfileId);

                entity.Property(p => p.Bio)
                      .HasMaxLength(1000);

                entity.Property(p => p.WebsiteUrl)
                      .HasMaxLength(300);

                entity.Property(p => p.LogoUrl)
                      .HasMaxLength(500);

                entity.HasOne(p => p.Organizer)
                      .WithOne(o => o.Profile)
                      .HasForeignKey<OrganizerProfile>(
                          p => p.OrganizerId)
                      .IsRequired();
            });
            modelBuilder.ApplyConfiguration(
                new EventConfiguration());

            modelBuilder.ApplyConfiguration(
                new BadgeConfiguration());
        }
    }
}
