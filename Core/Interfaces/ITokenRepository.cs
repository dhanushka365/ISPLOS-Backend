using Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Interfaces
{
    public interface ITokenRepository
    {
        string CreateJWTToken(User user, Role Role, int Time);

    }
}
