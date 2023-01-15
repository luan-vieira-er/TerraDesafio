using TerraDesafio.Dtos;
using TerraDesafio.Models;

namespace TerraDesafio.Interfaces
{
    public interface IRepositorioService{
        Task<ResponseGenerico<RepositorioResponse>> BuscarDadosRepositorio(string owner, string name);
        Task<ResponseGenerico<List<RepositorioResponse>>> BuscarRepositorios();
    }
    
}