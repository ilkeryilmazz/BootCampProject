﻿using Core.Repositories.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Abstracts
{
    public interface IBootcampRepository : IAsyncRepository<Bootcamp,Guid>
    {

    }


}
