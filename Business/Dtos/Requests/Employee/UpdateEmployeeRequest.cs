namespace Business.Dtos.Requests.Employee
{
    public class UpdateEmployeeRequest
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }

}
