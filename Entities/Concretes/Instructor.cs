﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
public class Instructor: User
    {
      
        public string CompanyName { get; set; }
        public virtual ICollection<Bootcamp> Bootcamps { get; set; }

       
    }
}
