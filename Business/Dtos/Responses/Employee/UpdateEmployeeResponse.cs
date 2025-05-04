namespace Business.Dtos.Responses.Employee
{
    public class UpdateEmployeeResponse
    {
        public Guid Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
    }


}
