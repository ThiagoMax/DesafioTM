using System;

namespace DesafioTM.Model
{
    public class PurchaseDTO
    {
        public long Id { get; set; }
        public long User_id { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
