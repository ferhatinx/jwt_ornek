using JwtApi.TokenHandler;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controllers;

[Route("[controller]")]
[ApiController]
public class AuthsController : ControllerBase
{
    [HttpPost]
    public IActionResult Login()
    {
        return Created("", new TokenGenerator().GenerateToken());
    }
}
