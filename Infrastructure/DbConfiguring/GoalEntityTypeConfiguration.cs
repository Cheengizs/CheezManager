using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DbConfiguring;

public class GoalEntityTypeConfiguration : IEntityTypeConfiguration<GoalEntity>
{
    public void Configure(EntityTypeBuilder<GoalEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Description)
            .HasMaxLength(200);
        
        builder.Property(g => g.ShortName)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.ToTable(t =>
        {
            t.HasCheckConstraint("CK_GoalEntity_Amount", "\"Amount\" >= 1");
        });

        builder.HasOne(c => c.Category)
            .WithMany(c => c.Goals)
            .HasForeignKey(c => c.CategoryId);

        builder.HasOne(c => c.User)
            .WithMany(u => u.Goals)
            .HasForeignKey(g => g.UserId);
        
    }
}