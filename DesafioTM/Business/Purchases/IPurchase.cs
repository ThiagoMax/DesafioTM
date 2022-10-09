using DesafioTM.Model;
using System.Collections.Generic;

namespace DesafioTM.Business.Purchases
{
    public interface IPurchase
    {
        PurchaseDTO Create(PurchaseDTO purchase);
        PurchaseDTO Update(PurchaseDTO purchase);
        void Delete(long id);
        PurchaseDTO FindById(long id);
        List<PurchaseDTO> FindByUserId(long id);
        List<PurchaseDTO> FindByPurchaseDate(string date);
        List<PurchaseDTO> FindAll();
    }
}
