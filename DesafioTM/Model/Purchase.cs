using DesafioTM.Model.Base;
using System;

namespace DesafioTM.Model
{
    public class Purchase : BaseEntity
    {
        public User Usuario_id { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
