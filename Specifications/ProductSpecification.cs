using SpecificationPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specifications
{
    public class ProductSpecification : BaseSpecification<Product>
    {
        public ProductSpecification(string? brand = "", string? type = "")
        {
            Criteria = p => ((string.IsNullOrEmpty(brand) || string.IsNullOrWhiteSpace(brand) || p.Brand == brand) && (string.IsNullOrEmpty(type) || string.IsNullOrWhiteSpace(type) || p.Type == type));
        }
    }
}
