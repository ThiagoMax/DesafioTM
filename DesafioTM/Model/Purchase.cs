using DesafioTM.Model.Base;
using System;

namespace DesafioTM.Model
{
    public class Purchase : BaseEntity
    {
        public User User_id { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
