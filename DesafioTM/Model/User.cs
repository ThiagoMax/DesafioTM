using DesafioTM.Model.Base;

namespace DesafioTM.Model
{
    public class User : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
