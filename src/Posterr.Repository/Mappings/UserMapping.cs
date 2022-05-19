using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Posterr.Domain.Entities;

namespace Posterr.Repository.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                .HasMaxLength(16)
                .HasColumnType("varchar(1024)");

            builder.HasMany(x => x.Follows)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.ToTable("User");
        }
    }
}
