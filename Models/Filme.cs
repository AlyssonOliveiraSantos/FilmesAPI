using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage = "O titulo é obrigatorio!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O genero é obrigatorio!")]
        [MaxLength(50, ErrorMessage = "O genero não pode ter mais que 50 caracteres")]
        public string Genero { get; set; }
        [Required]
        [Range(1, 300, ErrorMessage = "A duração deve está entre 1 e 300")]
        public int Duracao { get; set; }

    }
}
