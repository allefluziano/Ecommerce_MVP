using Ecommerce.Models;
using Ecommerce.Models.ViewModels;
using Ecommerce.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Interfaces
{
    public interface IProdutoRepository
    {
        Task SaveProdutosAsync(List<Livro> livros);
        Task<IList<Produto>> GetProdutosAsync();
        Task<BuscaProdutosViewModel> GetProdutosAsync(string pesquisa);
    }
}
