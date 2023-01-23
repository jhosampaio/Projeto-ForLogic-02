using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.OpCuriosidade.UI.Models
{
    [Table(nameof(TipoStatus))]
    public class TipoStatus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column (TypeName = "varchar")]
        [StringLength(50)]
        public string Nome { get; set;}

        public virtual ICollection<Colaborador> Colaboradores { get; set;}
    }
}