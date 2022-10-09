using DesafioTM.Model.DTO;
using System.Collections.Generic;

namespace DesafioTM.Business
{
    public interface IUsers
    {
        UsersDTO Create(UsersDTO user);
        GetIdUsersDTO FindById(long id);
        List<UsersDTO> FindByName(string name);
        List<UsersDTO> FindByType(string type);
        UsersDTO Update(UsersDTO user);
        void Delete(long id);
        List<UsersDTO> FindAll();
    }
}
