using ConsoleApp23.Common;
using ConsoleApp23.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Business
{
    internal class ProductBusiness
    {
        private ProductData manager = new ProductData();
        public List<Product> GetAll()
        {
            return manager.GetAll();
        }
        public void Add(Product product)
        {
            manager.Add(product);
        }
    }
}
