using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop.Models
{
    public class LineItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public LineItem(int id, int quantity, Product product)
        {
            ID = id;
            Quantity = quantity;
            Product = product;
        }

        public double CalculateLineItemCost()
        {
            double lineitemcost = Product.ProductPriceAfterDiscount * Quantity;
            return lineitemcost;
        }


    }
}
