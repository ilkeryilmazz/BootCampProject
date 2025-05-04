using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Applicant
{
   public class UpdateApplicantResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string Password { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
