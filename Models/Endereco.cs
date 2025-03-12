using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo logradouro é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O tamanho maximo é de 100 caracteres")]
        public string Logradouro { get; set; }
        public int Numero { get; set; }

        public virtual Cinema Cinema { get; set; }
    }
}
