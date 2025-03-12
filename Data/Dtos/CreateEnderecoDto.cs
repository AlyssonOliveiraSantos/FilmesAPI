using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateEnderecoDto
    {

        [Required(ErrorMessage = "O campo logradouro é obrigatorio")]
        [StringLength(100, ErrorMessage = "O tamanho maximo é de 100 caracteres")]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
