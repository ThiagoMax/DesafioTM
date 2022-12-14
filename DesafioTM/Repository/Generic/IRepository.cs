using DesafioTM.Model.Base;
using System.Collections.Generic;

namespace DesafioTM.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        List<T> FindAll();
        T FindById(long id);
        T Update(T item);
        void Delete(long id);
    }
}
