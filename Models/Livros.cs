using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeLivros.Models
{
    public class Livros
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio")]
        [MaxLength(255)]
        [MinLength(3)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio")]
        [MaxLength(255)]
        [MinLength(3)]
        public string Autor { get; set; }

        public char ISBN { get; set; }
    }
}