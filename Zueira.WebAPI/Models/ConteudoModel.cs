using System.ComponentModel.DataAnnotations;
namespace Zueira.WebAPI.Models
{
    public class ConteudoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Texto campo obrigatório")]
        public string Texto { get; set; }

        public int IdTag { get; set; }

        public virtual TagModel Tag { get; set; }
    }
}
