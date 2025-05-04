namespace Business.Dtos.Responses.Employee
{
    public class GetByIdEmployeeResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
    }


}
