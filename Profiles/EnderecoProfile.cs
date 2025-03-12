using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.Identity.Client;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {

            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
