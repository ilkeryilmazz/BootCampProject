using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Applicant: Core.Entities.User
    {
        public string About { get; set; }
        public virtual Blacklist Blacklist { get; set; }
    }
}
