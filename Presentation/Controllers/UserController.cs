using AutoMapper;
using Domain.Models;
using Domain.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation.RequestDto;
using Presentation.ResponseDto;
using Presentation.Services;

namespace Presentation.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IPasswordService _passwordService;
    private readonly IMapper _mapper;
    
    public UserController(IUserService userService, IMapper mapper, IPasswordService passwordService)
    {
        _userService = userService;
        _passwordService = passwordService;
        _mapper = mapper;
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        var user = await _userService.FindUserAsync(id);
        if (user == null)
            return NotFound();
    
        return Ok(_mapper.Map<UserResponseDto>(user));
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserAsync([FromBody] UserRegisterRequestDto userDto)
    {
        User user = new User()
        {
            Email = userDto.Email,
            Username = userDto.Username,
            CreatedDate = DateTime.UtcNow,
        };
        
        user.PasswordHash = _passwordService.HashPassword(userDto.Password);
        
        await _userService.CreateUserAsync(user);
        
        return Created($"api/user", _mapper.Map<UserResponseDto>(user));
    }
}   