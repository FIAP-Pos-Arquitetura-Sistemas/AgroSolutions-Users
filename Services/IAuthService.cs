using Microsoft.AspNetCore.Identity;
using static AgroSolutions_Users.DTO.AuthDTOS;

namespace IdentityService.Services;

public interface IAuthService
{
    Task<IdentityResult> RegisterAsync(RegisterDto model);
    Task<string?> LoginAsync(LoginDto model);
}