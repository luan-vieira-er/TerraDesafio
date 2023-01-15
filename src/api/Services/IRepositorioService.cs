using AutoMapper;
using TerraDesafio.Dtos;
using TerraDesafio.Interfaces;
using TerraDesafio.Models;

namespace TerraDesafio.Services
{
    public class RepositorioService : IRepositorioService{

        private readonly IMapper _mapper;
        private readonly IGitHubAPI _gitHub;

        public RepositorioService(IMapper mapper, IGitHubAPI github){
            _mapper = mapper;
            _gitHub = github;
        }

        public Task<ResponseGenerico<RepositorioResponse>> BuscarDadosRepositorio(string owner, string name)
        {
            throw new NotImplementedException();
        }
        async Task<ResponseGenerico<List<RepositorioResponse>>> IRepositorioService.BuscarRepositorios()
        {
            var response = await _gitHub.BuscarTodosRepositoriosPublicos();
            return _mapper.Map<ResponseGenerico<List<RepositorioResponse>>>(response);

        }
    }
    
}