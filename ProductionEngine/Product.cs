using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionEngine
{
    public class Product
    {
        public string productName { get; set; }
        public decimal productPrice { get; set; }
    }
    public interface IProductService
    {
        void GetPriceByType(Product product);
        int GetTotalPrice(List<Product> products);
    }

}
