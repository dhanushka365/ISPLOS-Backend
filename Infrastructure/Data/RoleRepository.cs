using Core.Entities.Identity;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        private readonly StoreContext context;

        public RoleRepository(StoreContext context) : base(context)
        {
            this.context = context;
        }

        public async Task SaveAsync()
        {
           await context.SaveChangesAsync();     
        }
    }
}
