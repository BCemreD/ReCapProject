using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

        List<Product> GetById(Product product);
        
    }
}
