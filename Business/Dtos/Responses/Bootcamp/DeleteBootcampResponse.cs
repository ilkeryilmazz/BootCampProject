using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Bootcamp
{
   public class DeleteBootcampResponse
    {
        public Guid Id { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
