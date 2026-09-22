namespace CustomerManagement.API.DTOs
{
    public class CreateCustomerDto
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}