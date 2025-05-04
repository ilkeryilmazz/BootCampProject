using Core.Entities;
using Core.Repositories.Abstracts;
using Core.Repositories.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes.EntityFramework
{
    public class UserRepository:EfRepositoryBase<User, Guid, BaseDbContext>, IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
