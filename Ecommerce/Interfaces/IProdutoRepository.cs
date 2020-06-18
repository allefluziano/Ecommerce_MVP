using System.Collections.Generic;

namespace Ecommerce.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}