using Ecommerce.Models;
using System.Linq;

namespace Ecommerce.Repositories
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
           return dbSet.Where(ip => ip.Id == itemPedidoId).SingleOrDefault();
        }
    }
}
