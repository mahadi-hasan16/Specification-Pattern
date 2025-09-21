using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public Func<T, bool> Criteria { get; set; } = p => true;
    }
}
