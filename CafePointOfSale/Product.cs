using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePointOfSale
{
    public enum Category
    {
        BakeryItem,
        CoffeeItem
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(Inventory inventory, string name, Category category, string description, decimal price)
        {
            Id = inventory.Products.Count + 1;
            Name = name;
            Category = category;
            Description = description;
            Price = price;
        }
    }
}
