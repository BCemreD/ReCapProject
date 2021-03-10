using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetAll();
            foreach (var product in result) 
            {

                Console.WriteLine("Araç......" + product.Description  + "  Fiyat....." + product.DailyPrice);
            }
            Console.WriteLine();
        }
    }
}
