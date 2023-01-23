using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FL.OpCuriosidade.UI.Models
{

    [Table(nameof(Usuario))]
    public class Usuario 
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Column(TypeName = "varchar")]
        [Required, StringLength(80)]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [Required, StringLength(100)]
        public string Senha { get; set; }
    }
}