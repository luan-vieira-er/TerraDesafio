using TerraDesafio.Dtos;
using TerraDesafio.Models;

namespace TerraDesafio.Interfaces{
    public interface IGitHubAPI{
        Task<ResponseGenerico<RepositorioModel>> BuscarDadosRepositorio(string owner, string name);
        Task<ResponseGenerico<List<RepositorioModel>>> BuscarTodosRepositoriosPublicos();
    }
}