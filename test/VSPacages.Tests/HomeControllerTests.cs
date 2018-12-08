using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using VSpackages.Controllers;
using VSpackages.Models;
using Xunit;

namespace VSPacages.Tests
{
  public class HomeControllerTests
    {
        class ModelCompleteFakeRepository: IRepository
        {
            public IEnumerable<Product> Products { get; } = new Product[]
            {
                new Product {Name = "P1", Price=275M},
                new Product {Name = "P2", Price=50M},
                new Product {Name = "P3", Price=5M},
                new Product {Name = "P4", Price=75M}
            };
            public void AddProduct(Product p)
            {
                // null
            }
        }
        [Fact]
        public void IndexActionModelIsComplete()
        {
            //org
            var controller = new HomeController();
            controller.Repository = new ModelCompleteFakeRepository();
            //do
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;

            Assert.Equal(controller.Repository.Products, model, Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
        }
        class ModelCompleteFakeRepositoryPricesUndo50 : IRepository
        {
            public IEnumerable<Product> Products { get; } = new Product[]
            {
                new Product {Name="P1", Price = 5M},
                new Product {Name="P2", Price = 15M},
                new Product {Name="P3", Price = 25M},
                new Product {Name="P4", Price = 35M}
            };
            public void AddProduct(Product p)
            {
                // null
            }
        }
        [Fact]
        public void IndexActionModelIsCompletePriceUnder50()
        {
            //org
            var controller = new HomeController();
            controller.Repository = new ModelCompleteFakeRepositoryPricesUndo50();
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            Assert.Equal(controller.Repository.Products, model, Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
        }
        }
    }

