using System.ComponentModel.DataAnnotations;

namespace FL.OpCuriosidade.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O email é obrigatorio")]
        [StringLength(80, ErrorMessage = "Limite Excedido")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "Email inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(40, ErrorMessage = "O Limite da {0} é de {1} caracteres")]
        public string Senha { get; set; }
        public bool PermanecerLogado { get; set; }        
        public string ReturnURL { get; set; }
    }

}