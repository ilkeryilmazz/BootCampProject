namespace Business.Dtos.Responses.Blacklist
{
    public class GetByIdBlacklistResponse
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
        public Guid ApplicantId { get; set; }
        public DateTime Date { get; set; }
    }
}
