﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePointOfSale
{
    public class Inventory
    {
        public Dictionary<Product, int> Products { get; set; }
        public Inventory(Dictionary<Product, int> products)
        {
            this.Products = products;
        }
    }
}
