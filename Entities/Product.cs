using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SpecificationPattern.Entities
{
    public class Product
    {
        public Product(int id, string name, double price, string brand, string type) 
        {
            Id = id; 
            Name = name; 
            Price = price; 
            Brand = brand; 
            Type = type;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}
