using AutoMapper;
using Domain.Models;
using Presentation.RequestDto;
using Presentation.ResponseDto;

namespace Presentation.MapProfiles;

public class UserDtoProfile : Profile
{
    public UserDtoProfile()
    {
        // Domain -> Entity
        CreateMap<User, UserRequestDto>();
        CreateMap<UserRequestDto, User>();
        
        CreateMap<User, UserResponseDto>();
        CreateMap<UserResponseDto, User>();
    }
}