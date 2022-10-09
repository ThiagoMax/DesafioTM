using DesafioTM.Model;
using DesafioTM.Repository.Generic;
using System;
using System.Collections.Generic;

namespace DesafioTM.Repository.Purchases
{
    public interface IPurchaseRepository : IRepository<Purchase>
    {
        List<Purchase> FindByUserId(long id);
        List<Purchase> FindByPurchaseDate(DateTime date);
    }
}
