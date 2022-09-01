using Shopping.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Client.Services
{
    public interface IShoppingService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
