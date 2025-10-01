using AutoMapper;
using Domain.Models;
using Infrastructure.Entities;

namespace Infrastructure.MapProfiles;

public class DomainEntityMappingProfile : Profile
{
    public DomainEntityMappingProfile()
    {
        // Domain -> Entity
        CreateMap<User, UserEntity>();
        CreateMap<Goal, GoalEntity>();
        CreateMap<Category, CategoryEntity>();

        // Entity -> Domain
        CreateMap<UserEntity, User>();
        CreateMap<GoalEntity, Goal>();
        CreateMap<CategoryEntity, Category>();
    }
}