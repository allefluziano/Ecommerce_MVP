using Ecommerce.Models;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Interfaces
{
    public interface IHttpHelper
    {
        IConfiguration Configuration { get; }
        int? GetPedidoId();
        void SetPedidoId(int pedidoId);
        void ResetPedidoId();
        void SetCadastro(Cadastro cadastro);
        Cadastro GetCadastro();
    }
}
