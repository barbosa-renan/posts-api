using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Posterr.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Posterr.Repository.Mappings
{
    public class PostMapping : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Text)
                .HasMaxLength(777)
                .HasColumnType("varchar(1024)");

            // N : 1 => User : Post
            builder.HasOne(x => x.Owner)
                .WithMany(u=>u.Posts)
                .HasForeignKey(x => x.OwnerId);

            builder.ToTable("Post");
        }
    }
}
