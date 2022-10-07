using DesafioTM.Model.Base;
using DesafioTM.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTM.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        public readonly MySQLContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            return dataset.SingleOrDefault(item => item.Id.Equals(id));
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return item;
        }

        public T Update(T item)
        {
            var exist = dataset.SingleOrDefault(i => i.Id.Equals(item.Id));

            if (exist != null)
            {
                try
                {
                    _context.Entry(exist).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return item;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }

        public void Delete(long id)
        {
            var exist = dataset.SingleOrDefault(item => item.Id.Equals(id));

            if (exist != null)
            {
                try
                {
                    dataset.Remove(exist);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
