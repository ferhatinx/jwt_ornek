using JwtApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly UserContext _context;

    public UsersController(UserContext context)
    {
        _context = context;
    }
    [HttpGet("Users")]
    public IActionResult Users()
    {
        var users = _context.Users.ToList();
        return Ok(users);
    }
    [HttpGet("Roles")]
    public IActionResult Roles()
    {
        var roles = _context.Roles.ToList();
        return Ok(roles);
    }
}
