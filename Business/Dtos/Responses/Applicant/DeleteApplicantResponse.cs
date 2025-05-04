using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Applicant
{
    public class DeleteApplicantResponse
    {
        public Guid Id { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
