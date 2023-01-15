using System.Dynamic;
using System.Text.Json;
using TerraDesafio.Dtos;
using TerraDesafio.Interfaces;
using TerraDesafio.Models;

namespace TerraDesafio.Rest {
    public class GitHubRest : IGitHubAPI
    {
        public Task<ResponseGenerico<RepositorioModel>> BuscarDadosRepositorio(string owner, string name)
        {
            throw new NotImplementedException();
        }
        public async Task<ResponseGenerico<List<RepositorioModel>>> BuscarTodosRepositoriosPublicos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.github.com/repositories");
            var response = new ResponseGenerico<List<RepositorioModel>>();
            using (var cliente = new HttpClient()){
                var responseGitHub = await cliente.SendAsync(request);
                var contentResp = await responseGitHub.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<RepositorioModel>>(contentResp);

                if (responseGitHub.IsSuccessStatusCode){
                    response.CodigoHttp = responseGitHub.StatusCode;
                    response.DadosRetorno = objResponse;
                    response.CodigoHttp = responseGitHub.StatusCode;
                } else {
                    response.ErroRetorno = JsonSerialize<ExpandoObject>(contentResp);
                }
                return response;
            }
        }

        private ExpandoObject? JsonSerialize<T>(string contentResp)
        {
            throw new NotImplementedException();
        }
    }
}