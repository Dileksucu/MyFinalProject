using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint - generik kısıt
    // class:
    interface IEntityRepository<T> 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        //e-ticarette filitrele mantığı için kullanılır -şu ürünleri getir- gibi
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


        




    }
}
