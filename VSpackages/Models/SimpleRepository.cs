using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSpackages.Models
{
    public class SimpleRepository: IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository SharedRepository => sharedRepository;
        public SimpleRepository()
        {
            var initialitems = new[]
            {
                new Product { Name = "tits", Price = 275M },
                new Product { Name = "kits", Price = 15M },
                new Product { Name = "sits", Price = 135M },
                new Product { Name = "hits", Price = 5M }
            };
            foreach (var p in initialitems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);
        }
        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product P) => products.Add(P.Name, P);
    }
}
