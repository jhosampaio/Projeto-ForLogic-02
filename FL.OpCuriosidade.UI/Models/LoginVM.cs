using System.ComponentModel.DataAnnotations;

namespace FL.OpCuriosidade.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O email � obrigatorio")]
        [StringLength(80, ErrorMessage = "Limite Excedido")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "Email inv�lido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha � obrigat�ria")]
        [StringLength(40, ErrorMessage = "O Limite da {0} � de {1} caracteres")]
        public string Senha { get; set; }
        public bool PermanecerLogado { get; set; }        
        public string ReturnURL { get; set; }
    }

}