using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        object productDal { get; }

        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int Id);

        List<Product> GetByUnitPrice(decimal min , decimal max );


        


    }
}
