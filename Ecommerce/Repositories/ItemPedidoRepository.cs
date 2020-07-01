using Ecommerce.Models;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Ecommerce.Repositories
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
        void RemoveItemPedido(int itemPedidoId);
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(IConfiguration configuration, ApplicationContext contexto) : base(configuration, contexto)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
           return dbSet.Where(ip => ip.Id == itemPedidoId).SingleOrDefault();
        }

        public void RemoveItemPedido(int itemPedidoId)
        {
            dbSet.Remove(GetItemPedido(itemPedidoId));            
        }
    }
}
