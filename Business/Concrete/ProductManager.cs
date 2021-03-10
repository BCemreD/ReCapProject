using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

      

        public List<Product> GetById(Product product)
        {
            throw new NotImplementedException();
        }


        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()

        {
            return _productDal.GetAll();
        }
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
