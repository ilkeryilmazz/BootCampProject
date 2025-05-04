using Entities.Enums;

namespace Business.Dtos.Responses.Application
{
    public class GetByIdApplicationResponse
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; }

    }
}
