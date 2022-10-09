using DesafioTM.Model;
using DesafioTM.Repository.Generic;
using System.Collections.Generic;

namespace DesafioTM.Repository.User
{
    public interface IUsersRepository : IRepository<Users>
    {
        List<Users> FindByName(string name);
        List<Users> FindByType(string type);
    }
}
