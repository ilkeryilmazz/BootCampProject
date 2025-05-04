using Entities.Enums;

namespace Business.Dtos.Requests.Application
{
    public class UpdateApplicationRequest
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; }
    }
}