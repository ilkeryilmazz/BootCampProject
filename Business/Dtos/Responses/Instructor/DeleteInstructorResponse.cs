using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Instructor
{
   public class DeleteInstructorResponse
    {
        public Guid Id { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
