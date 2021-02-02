using Business.Concreat;
using System;

namespace ConsoleUI
{
    class Program
    {
        private static object product;

        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new InMemoryProductDal);

            foreach (var item in productManager.GetAll())

            {
                Console.WriteLine(product.ProductName);


            }

            
            
            
            Console.WriteLine("Hello World!");


        }
    }
}
