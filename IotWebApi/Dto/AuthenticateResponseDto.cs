using IotWebApi.Entities;

namespace IotWebApi.Dto
{
    public class AuthenticateResponseDto
    {
        public string Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Role { get; set; }
        public string Token { get; set; }


        public AuthenticateResponseDto(UserDto user, string role, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Role = role;
            Token = token;
        }
    }
}
