using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }
        public static int OrderCount;
        public List<LineItem> LineItems = new List<LineItem>();

        public Order(int id, DateTime date)
        {
            OrderId = id;
            OrderDate = date;
            OrderCount++;

        }

        public double CalculateOrderPrice()
        {
            double sum = 0;
            foreach (LineItem lineItem in LineItems)
            {
                sum = sum + lineItem.CalculateLineItemCost();

            }
            return sum;

        }

        public void AddLineItem(LineItem lineItem)
        {
            LineItems.Add(lineItem);
        }



    }
}
