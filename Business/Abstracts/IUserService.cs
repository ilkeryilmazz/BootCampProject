﻿
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
       
        Task<GetByIdUserResponse> GetById(GetByIdUserRequest getByIdUserRequest);
       
      

    }
}
