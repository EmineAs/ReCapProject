using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBaseService<Brand>
    {
        IBaseDal<Brand> _brandDal;

        public BrandManager(IBaseDal<Brand> brandDal)
        {
            _brandDal = brandDal;

        }
        public List<Brand> GetAll()
        {

            return _brandDal.GetAll();

        }
        public void Add(Brand brand) => _brandDal.Add(brand);

        public void Update(Brand brand) => _brandDal.Update(brand);

        public void Delete(Brand brand) => _brandDal.Delete(brand);

        public List<Brand> GetById(int id) => _brandDal.GetById(id);

    }   
}
