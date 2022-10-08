using AutoMapper;
using DesafioTM.Model;
using DesafioTM.Model.DTO;
using DesafioTM.Repository.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTM.Business.User
{
    public class UsersBusinessImp : IUsers
    {
        private readonly IUsersRepository _repository;
        private readonly IMapper _mapper;

        public UsersBusinessImp(IUsersRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public UsersDTO Create(UsersDTO user)
        {
            var userr = _repository.Create(_mapper.Map<Users>(user));
            return _mapper.Map<UsersDTO>(userr);
        }

        public UsersDTO FindById(long id)
        {
            var userr = _repository.FindById(id);
            return _mapper.Map<UsersDTO>(userr);
        }

        public List<UsersDTO> FindByName(string name)
        {
            var userr = _repository.FindByName(name);
            return _mapper.Map<List<UsersDTO>>(userr);
        }

        public List<UsersDTO> FindByType(string type)
        {
            var userr = _repository.FindByType(type);
            return _mapper.Map<List<UsersDTO>>(userr);
        }

        public UsersDTO Update(UsersDTO user)
        {
            var userr = _repository.Update(_mapper.Map<Users>(user));
            return _mapper.Map<UsersDTO>(userr);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<UsersDTO> FindAll()
        {
            var userr = _repository.FindAll();
            return _mapper.Map<List<UsersDTO>>(userr);
        }
    }
}
