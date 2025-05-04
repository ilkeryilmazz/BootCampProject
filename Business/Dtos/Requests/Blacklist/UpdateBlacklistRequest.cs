namespace Business.Dtos.Requests.Blacklist
{
    public class UpdateBlacklistRequest
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
        public Guid ApplicantId { get; set; }
        public DateTime Date { get; set; }
    }
}
