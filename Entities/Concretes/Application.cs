using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Application : BaseEntity<Guid>
    {
        public Guid ApplicantId { get; set; }
        public Guid BootcampId{ get; set; }
        public ApplicationState ApplicationState { get; set; }

        public virtual Applicant Applicant { get; set; }
        public virtual Bootcamp Bootcamp { get; set; }
    }
}
