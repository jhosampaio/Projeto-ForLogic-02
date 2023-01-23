using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.OpCuriosidade.UI.Models
{
    [Table(nameof(Colaborador))]
    public class Colaborador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(100)]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Data_nasc { get; set; }
        public string End { get; set; }
        public string outras { get; set; }
        public string inte { get; set; }
        public string sent { get; set; }
        public string valo { get; set; }        
        public int TipoStatusId { get; set; }
        
        public virtual TipoStatus TipoStatus { get; set; }
     }
}