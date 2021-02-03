using Business.Concreat;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        private static object product;

       public static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAll())

            {
                Console.WriteLine(product.ProductName);


            }

          

        }
    }
}
