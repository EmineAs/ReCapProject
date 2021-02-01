using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBaseDal<T>
    {
        List<T> GetAll();
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);

        List<T> GetById(int id);
    }
}
