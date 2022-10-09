using DesafioTM.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioTM.Model
{
    [Table("purchase")]
    public class Purchase : BaseEntity
    {
        [Column("user_id")]
        public long User_id { get; set; }

        [Column("payment_method")]
        public string PaymentMethod { get; set; }

        [Column("date_purchase")]
        public DateTime PurchaseDate { get; set; }
    }
}
