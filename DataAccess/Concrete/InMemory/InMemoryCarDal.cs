using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess.InMemory
{
    public class InMemoryCarDal: IBaseDal<Car>
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,ColorId=1,BrandId=1, ModelYear="2020", DailyPrice=100000,Description="Açıklama"},
                new Car {Id=2,ColorId=1,BrandId=1, ModelYear="2019", DailyPrice=120000,Description="Açıklama"},
                new Car {Id=3,ColorId=2,BrandId=2, ModelYear="2019", DailyPrice=125000,Description="Açıklama"},
                new Car {Id=4,ColorId=2,BrandId=2, ModelYear="2020", DailyPrice=130000,Description="Açıklama"},
                new Car {Id=5,ColorId=2,BrandId=3, ModelYear="2020", DailyPrice=140000,Description="Açıklama"},

            };

        }

        public void Add(Car car)
        {


            _cars.Add(car);

            Console.WriteLine(car.Id + " nolu Araç Eklendi");
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

            Console.WriteLine(car.Id + " nolu Araç Güncellendi");

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            Console.WriteLine(car.Id + " nolu Araç Silindi");

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }


    }
}
