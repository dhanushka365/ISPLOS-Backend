using Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRoleRepository : IGenericRepository<Role>
    {

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public Task SaveAsync();
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

    }
}
