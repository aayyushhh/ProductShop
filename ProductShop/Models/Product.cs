using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double DiscountPercentage { get; set; }
        public double ProductPriceAfterDiscount { get; set; }

        public Product(int id, string name, double price, double discountpercent)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
            DiscountPercentage = discountpercent;
            ProductPriceAfterDiscount = Calculate_Discounted_Price(ProductPrice, DiscountPercentage);


        }

        public double Calculate_Discounted_Price(double price, double discountpercent)
        {
            double discount_price = ProductPrice - DiscountPercentage / 100 * ProductPrice;
            return discount_price;
        }

    }
}
