namespace CustomerManagement.API.DTOs
{
    public class UpdateUserDto
    {
        public string Username { get; set; } = string.Empty;
        // Để trống nếu không muốn đổi password
        public string? Password { get; set; }
        public string Role { get; set; } = "Admin";
    }
}
