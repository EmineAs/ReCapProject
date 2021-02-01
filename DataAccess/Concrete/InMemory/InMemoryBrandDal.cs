using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBaseDal<Brand>
    {

        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand {BrandId=1, BrandName="Opel" },
                new Brand {BrandId=2, BrandName="Audio" }, 
                new Brand {BrandId=3, BrandName="Mercedes" },
                new Brand {BrandId=4, BrandName="Fiat" },
            };

        }


        public void Add(Brand brand)
        {
           
            _brands.Add(brand);

            Console.WriteLine(brand.BrandId+" nolu Model Eklendi");
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId== brand.BrandId);
            _brands.Remove(brandToDelete);
            Console.WriteLine(brand.BrandId + " nolu Model Silindi");
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetById(int id)
        {
            return _brands.Where(b => b.BrandId == id).ToList();
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);

            brandToUpdate.BrandName = brand.BrandName;

            Console.WriteLine(brand.BrandId + " nolu Renk Güncellendi");
        }
    }
}
