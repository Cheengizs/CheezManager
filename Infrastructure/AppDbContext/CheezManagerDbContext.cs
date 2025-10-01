using Domain.Models;
using Infrastructure.DbConfiguring;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.AppDbContext;

public class CheezManagerDbContext : DbContext
{
    public CheezManagerDbContext(DbContextOptions<CheezManagerDbContext> options) : base(options){}
    
    public DbSet<UserEntity?> Users { get; set; }
    public DbSet<GoalEntity> Goals { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new GoalEntityTypeConfiguration().Configure(modelBuilder.Entity<GoalEntity>());
        new CategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<CategoryEntity>());
        new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<UserEntity>());
    }
}