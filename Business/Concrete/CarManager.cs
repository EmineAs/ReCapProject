using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : IBaseService<Car> 
    {
        IBaseDal<Car> _carDal;

        public CarManager(IBaseDal<Car> carDal)
        {
            _carDal = carDal;

        }
        public  List<Car> GetAll()
        {

            return _carDal.GetAll();

        }
        public void Add(Car car) => _carDal.Add(car);

        public void Update(Car car) => _carDal.Update(car);

        public void Delete(Car car) => _carDal.Delete(car);

        public List<Car> GetById(int id) => _carDal.GetById(id);





    }
}
