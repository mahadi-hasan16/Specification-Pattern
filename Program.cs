using SpecificationPattern.Data;

Shop shop = new Shop();
var products = shop.GetProducts();

foreach(var product in products)
{
    Console.WriteLine(product.Name);
}