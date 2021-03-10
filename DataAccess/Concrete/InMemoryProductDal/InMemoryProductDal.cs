using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemoryProductDal
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
          {
            new Product {Id=1, BrandId=1, ColorId=2, ModelYear="2007", DailyPrice=200000, Description="Black X7" },
            new Product {Id=2, BrandId=1, ColorId=3, ModelYear="2012", DailyPrice=85000, Description="Red Micra" },
            new Product {Id=3, BrandId=1, ColorId=1, ModelYear="2005", DailyPrice=100000, Description="Blue Corsa"}
          };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllById(int Id)
        {
            throw new NotImplementedException();
        }

             public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.Description = product.Description;
        } 
    }
}
