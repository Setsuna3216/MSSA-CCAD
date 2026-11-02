using Mod7ProductDBApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7ProductDBApp.Services
{
    public interface ICRUD
    {
        void AddProduct(Product prod);
        List<Product> GetProducts();
        Product? GetProductById(int id);

        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
