using DesafioTM.Model.Base;
using System.Collections.Generic;

namespace DesafioTM.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T evento);
        T FindById(long id);
        T Update(T evento);
        void Delete(long id);
        List<T> FindAll();
    }
}
