using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioTM.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
