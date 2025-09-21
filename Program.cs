using SpecificationPattern.Data;
using SpecificationPattern.Entities;
using SpecificationPattern.Specifications;
using System.Linq;

Shop shop = new Shop();
var products = shop.GetProducts();
//Func<Product, bool> criteria = x => x.Brand == "Samsung" && x.Price >= 100000;
ISpecification<Product> specification = new ProductSpecification("Samsung", "");
products = products.Where(specification.Criteria);

foreach(var product in products)
{
    Console.WriteLine(product.Name);
}