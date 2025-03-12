using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private IMapper _mapper;
        private FilmeContext _context;

        public EnderecoController(IMapper mapper, FilmeContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaEndereco(CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaTodosEnderecos), new { id = endereco.Id }, enderecoDto);
        }

        [HttpGet]
        public IEnumerable<ReadEnderecoDto> RecuperaTodosEnderecos()
        {
            return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult ReperaEnderecoPorId(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null) return NotFound();
            var enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if(endereco == null) return NotFound();
            _mapper.Map(enderecoDto, endereco);
            _context.Update(endereco);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if(endereco == null) return NotFound();
            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
