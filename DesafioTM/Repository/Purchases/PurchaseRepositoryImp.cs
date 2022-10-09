using DesafioTM.Model;
using DesafioTM.Model.Context;
using DesafioTM.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioTM.Repository.Purchases
{
    public class PurchaseRepositoryImp : GenericRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepositoryImp(MySQLContext context) : base(context) { }

        public List<Purchase> FindByUserId(long id)
        {
            var user_id = _context.Users.SingleOrDefault(u => u.Id.Equals(id));
            var purchases_user = _context.Purchases.Where(p => p.User_id.Equals(user_id.Id)).ToList();
            return purchases_user;
        }

        public List<Purchase> FindByPurchaseDate(DateTime date)
        {
            var purchases_date = _context.Purchases.Where(e => e.PurchaseDate.Date.Equals(date)).ToList();
            return purchases_date;
        }
    }
}
