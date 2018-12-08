using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSpackages.Models
{
    public class IRepository
    {
        IEnumerable<Product>Products { get; }
        void AddProduct(Product p);
    }
}
