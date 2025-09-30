using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DbConfiguring;

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.
            HasKey(x => x.Id);
        
        builder.Property(u => u.Username)
            .IsRequired()
            .HasMaxLength(14);
        
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.CreatedDate)
            .HasColumnType("timestamp without time zone")  // тип PostgreSQL
            .HasDefaultValueSql("NOW()")                   // PostgreSQL автоматически ставит текущую дату/время
            .ValueGeneratedOnAdd();  
    }
}