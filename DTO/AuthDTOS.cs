namespace AgroSolutions_Users.DTO
{
    public class AuthDTOS
    {
        public record RegisterDto(string Nome, string Email, string Password);
        public record LoginDto(string Email, string Password);
    }
}
