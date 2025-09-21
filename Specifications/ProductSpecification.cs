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
        public ProductSpecification(string? brand, string? type)
        {
            _brand = brand;
            _type = type;
            SetCriteria();
        }
        private string? _brand = string.Empty;
        private string? _type = string.Empty;
                
        public Func<Product, bool> criteria = p => true;

        private void SetCriteria()
        {
            criteria = p => (string.IsNullOrEmpty(_brand) || p.Brand == _brand) && (string.IsNullOrWhiteSpace(_type) || p.Type == _type);
        }
    }
}
