using System;
using System.Threading.Tasks;

namespace Ecommerce
{
    public interface IDataService
    {
        Task InicializaDBAsync(IServiceProvider provider);
    }
}