using DesafioTM.Model;
using DesafioTM.Model.Context;
using DesafioTM.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTM.Repository.User
{
    public class UsersRepositoryImp : GenericRepository<Users>, IUsersRepository
    {
        public UsersRepositoryImp(MySQLContext context) : base(context) {}

        public List<Users> FindByName(string name)
        {
            var users_name = _context.Users.Where(u => u.Name.Contains(name)).ToList();
            return users_name;
        }

        public List<Users> FindByType(string type)
        {
            var users_type = _context.Users.Where(u => u.Type.Contains(type)).ToList();
            return users_type;
        }
    }
}
