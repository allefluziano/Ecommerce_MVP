using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public interface IPedidoRepository
    {

    }
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
