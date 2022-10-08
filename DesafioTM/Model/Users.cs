using DesafioTM.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioTM.Model
{
    [Table("user")]
    public class Users : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        
        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("cpf_cnpj")]
        public string Cpf_cnpj { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}
