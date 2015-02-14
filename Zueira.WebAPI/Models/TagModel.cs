using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Zueira.WebAPI.Models
{
    public class TagModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Descrição campo obrigatório")]
        [MaxLength(500, ErrorMessage = "Máximo de {0} caracteres")]
        public string Descricao { get; set; }

        public int IdAssunto { get; set; }

        public virtual AssuntoModel Assunto { get; set; }

        public virtual ICollection<ConteudoModel> Conteudos { get; set; }
    }
}
