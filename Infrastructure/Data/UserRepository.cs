using Core.Entities.Identity;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(StoreContext context) : base(context)
        {
        }
    }
}
