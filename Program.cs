using SpecificationPattern.Data;
using SpecificationPattern.Entities;
using SpecificationPattern.Specifications;
using System.Linq;

Shop shop = new Shop();
var products = shop.GetProducts();
//Func<Product, bool> criteria = x => x.Brand == "Samsung" && x.Price >= 100000;
ProductSpecification specification = new ProductSpecification("Samsung", "");
var criteria = specification.criteria;
products = products.Where(criteria);

foreach(var product in products)
{
    Console.WriteLine(product.Name);
}