using DesafioTM.Model.Base;

namespace DesafioTM.Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
