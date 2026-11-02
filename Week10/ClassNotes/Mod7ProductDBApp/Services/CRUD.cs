using Mod7ProductDBApp.Data;
using Mod7ProductDBApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7ProductDBApp.Services
{
    
    //Emp obj;
    //obj.Calculate();
    public class CRUD : ICRUD
    {
        private ProductContext _productcontext;
        //constructor dependency injection
        public CRUD(ProductContext productcontext)
        {
            _productcontext = productcontext;
        }
        public void AddProduct(Product prod)
        {
            _productcontext.Products.Add(prod);
            _productcontext.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _productcontext.Products.Remove(product);
            _productcontext.SaveChanges();
        }

        public Product? GetProductById(int id)
        {
            return _productcontext.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return _productcontext.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            _productcontext.Products.Update(product);
            _productcontext.SaveChanges();
        }
    }
}
