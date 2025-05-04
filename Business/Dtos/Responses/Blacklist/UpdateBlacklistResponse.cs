namespace Business.Dtos.Responses.Blacklist
{
    public class UpdateBlacklistResponse
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
        public Guid ApplicantId { get; set; }
        public DateTime Date { get; set; }

    }
}
