using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public interface IItemPedidoRepository
    {

    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
