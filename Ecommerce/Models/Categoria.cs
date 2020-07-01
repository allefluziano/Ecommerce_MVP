using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Categoria : BaseModel
    {
        public Categoria() { }

        public Categoria(string nome)
        {
            Nome = nome;
        }
        [Required]
        public string Nome { get; private set; }
    }
}
