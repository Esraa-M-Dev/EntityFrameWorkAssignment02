using EntityFrameWorkAssignment02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkAssignment02.Configurations
{
    internal class BadgeConfiguration :IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.BadgeId);

            builder.Property(b => b.BadgeNumber)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(b => b.BadgeNumber)
                   .IsUnique();

            builder.Property(b => b.IssuedDate)
                   .IsRequired();

            builder.Property(b => b.Tier)
                   .IsRequired()
                   .HasConversion<string>()
                   .HasMaxLength(20);

            // Relationship: Attendee - Badge
            builder.HasOne(b => b.Attendee)
                   .WithOne(a => a.Badge)
                   .HasForeignKey<Badge>(b => b.AttendeeId);
        }
    }
}
