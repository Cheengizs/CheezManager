using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DbConfiguring;

public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<CategoryEntity>
{
    public void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.ShortName)
            .IsRequired()
                .HasMaxLength(50);
        
        builder.Property(c => c.Description)
            .HasMaxLength(300);

        builder.HasOne(c => c.User)
            .WithMany(u => u.Categories)
            .HasForeignKey(u => u.UserId);
        
        builder.HasMany(c => c.Goals)
            .WithOne(g => g.Category)
            .HasForeignKey(g => g.CategoryId);
    }
}