using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Posterr.Domain.Entities;

namespace Posterr.Repository.Mappings
{
    public class FollowMapping : IEntityTypeConfiguration<Follow>
    {
        public void Configure(EntityTypeBuilder<Follow> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId)
                .IsRequired()
                .HasColumnType("uniqueidentifier");

            builder.Property(x => x.UserFollowedId)
                .IsRequired()
                .HasColumnType("uniqueidentifier");

            builder.ToTable("Follow");
        }
    }
}
