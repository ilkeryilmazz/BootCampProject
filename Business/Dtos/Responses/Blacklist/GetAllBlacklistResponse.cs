using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Blacklist
{
    public class GetAllBlacklistResponse
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
        public Guid ApplicantId { get; set; }
        public DateTime Date { get; set; }
    }
}
