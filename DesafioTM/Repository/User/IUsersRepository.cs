using DesafioTM.Model;
using DesafioTM.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTM.Repository.User
{
    public interface IUsersRepository : IRepository<Users>
    {
        List<Users> FindByName(string name);
        List<Users> FindByType(string type);
    }
}
