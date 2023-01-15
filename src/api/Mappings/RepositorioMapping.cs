using AutoMapper;
using TerraDesafio.Dtos;
using TerraDesafio.Models;

namespace TerraDesafio.Mappings{
    public class RepositorioMapping : Profile{
        
        public RepositorioMapping(){
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<RepositorioResponse, RepositorioModel>();
            CreateMap<RepositorioModel, RepositorioResponse>();
        }
    }
}