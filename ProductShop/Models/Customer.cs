﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public static List<Order> OrdersList = new List<Order>();

        public Customer(int id, string name)
        {
            CustomerId = id;
            CustomerName = name;

        }




    }
}
