using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group5_Yash_Bhagy_Assignment2
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStockValue(int price)
        {
            if (price > 0)
            {
                Stock += price;
            }
        }

        public void DecreaseStockValue(int price)
        {
            if (price > 0 && price <= Stock)
            {
                Stock -= price;
            }
        }
    }
}
