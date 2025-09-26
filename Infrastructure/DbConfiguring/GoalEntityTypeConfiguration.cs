using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DbConfiguring;

public class GoalEntityTypeConfiguration : IEntityTypeConfiguration<GoalEntity>
{
    public void Configure(EntityTypeBuilder<GoalEntity> builder)
    {
        builder.
            HasKey(x => x.Id);
        
    }
}