using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Api.Models;
using Warehouse.Api.Services.UserService;

namespace Warehouse.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController: ControllerBase
{
    private readonly IUserService _userService;
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<User>>>> GetAll()
    {
        return Ok(await _userService.getAllUsers());
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<ServiceResponse<User>>> GetByCode(string code)
    {
        return Ok(await _userService.getByCode(code));
    }

    [HttpPut("{code}")]
    public async Task<ActionResult<ServiceResponse<List<User>>>> AddUser(string code)
    {
        return Ok(await _userService.AddUser(code));
    }
}