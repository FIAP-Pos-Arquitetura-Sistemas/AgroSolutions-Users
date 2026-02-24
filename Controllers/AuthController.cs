using IdentityService.Services;
using Microsoft.AspNetCore.Mvc;
using static AgroSolutions_Users.DTO.AuthDTOS;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto model)
    {
        var result = await _authService.RegisterAsync(model);
        if (result.Succeeded)
            return Ok(new { message = "Produtor rural cadastrado com sucesso!" });

        return BadRequest(result.Errors);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto model)
    {
        var token = await _authService.LoginAsync(model);
        if (token != null)
        {
            return Ok(new { token, message = "Login realizado com sucesso!" });
        }

        return Unauthorized("Credenciais inválidas.");
    }
}