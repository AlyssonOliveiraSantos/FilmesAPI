using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class ReadEnderecoDto
    {

        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
