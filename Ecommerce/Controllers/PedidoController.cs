using Ecommerce.Models;
using Ecommerce.Models.ViewModels;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecommerce.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IItemPedidoRepository itemPedidoRepository;

        public PedidoController(
            IProdutoRepository produtoRepository, 
            IPedidoRepository pedidoRepository,
            IItemPedidoRepository itemPedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoRepository.AddItem(codigo);
            }

            List<ItemPedido> itens = pedidoRepository.GetPedido().Itens;
            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itens);
            return View(carrinhoViewModel);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View(pedidoRepository.GetPedido());
        }

        [HttpPost]
        public void UpdateQuantidade([FromBody] ItemPedido itemPedido)
        {
            itemPedidoRepository.UpdateQuantidade(itemPedido);
        }
    }
}
