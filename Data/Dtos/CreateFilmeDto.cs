using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {

        [Required(ErrorMessage = "O titulo é obrigatorio!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O genero é obrigatorio!")]
        [StringLength(50, ErrorMessage = "O genero não pode ter mais que 50 caracteres")]
        public string Genero { get; set; }
        [Required]
        [Range(1, 300, ErrorMessage = "A duração deve está entre 1 e 300")]
        public int Duracao { get; set; }
    }
}
