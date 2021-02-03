using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> products;
        private object return_products;

        public InMemoryProductDal()
        {
            List<Product> lists = new List<Product>
            {
                new Product{ProductId=1 , CategoryId=1, ProductName="Bardak",UnitePrice=15, UnitsInStock=15};
            products = lists;
                new Product{ProductId=2 , CategoryId=1, ProductName="klavye",UnitePrice=500, UnitsInStock=3};
                new Product{ProductId=3 , CategoryId=2, ProductName="fare",UnitePrice=1500, UnitsInStock=2};
                new Product{ProductId=4 , CategoryId=2, ProductName="kamera",UnitePrice=150, UnitsInStock=65};
            new Product { ProductId = 5, CategoryId = 2, ProductName = "telefon", UnitePrice = 85, UnitsInStock = 1 };

            };

        }
        
        public void Add(Product product)
        {
            products.Add(product);

        }

        public void Delete(Product product)
        {
           Product productToDelete = null;
              // foreach (var p in products)

            {
                // if (product.ProductId == p.ProductId)
                {
                    // productToDelete = p;
                }
                

                productToDelete = products.SingleOrDefault(p=>p.ProductId == product.ProductId);

                // yorum satıra aldığımız yer yerine daha kısa yolu yazıldı 

            }


        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(in Category )
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //GÖNDERDİĞM ÜRÜN ID'SİNE SAHİP OLAN LİSTEDEKİ ÜRÜNÜ BUL


            Product productToUpdate = products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitePrice = product.UnitePrice;
            product.UnitsInStock = product.UnitsInStock;

        }
    }
}
