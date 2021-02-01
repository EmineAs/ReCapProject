using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;

            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            Brand brand1 = new Brand { BrandId = 5, BrandName = "Volswagen" };

            brandManager.Add(brand1);

            foreach (var brand in brandManager.GetAll())
            {
                Console.Write(brand.BrandId + "\t" +brand.BrandName + "\n");

            }

            Brand brand2 = new Brand { BrandId = 5, BrandName = "Toyota" };
            brandManager.Update(brand2);

            foreach (var brand in brandManager.GetAll())
            {
                Console.Write(brand.BrandId + "\t" + brand.BrandName + "\n");

            }

            Console.WriteLine("Silmek istediğiniz modelin idsini girin...");
            id = Convert.ToInt32(Console.ReadLine());


            List<Brand> brands = new List<Brand>();
            brands = brandManager.GetById(id);

            brandManager.Delete(brands[0]);

            foreach (var brand in brandManager.GetAll())
            {
                Console.Write(brand.BrandId + "\t" + brand.BrandName + "\n");

            }

            Console.WriteLine("----------------------------------------------------\n");


            ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            Color color1 = new Color { ColorId = 4, ColorName = "Yeşil" };

            colorManager.Add(color1);

            foreach (var color in colorManager.GetAll())
            {
                Console.Write(color.ColorId + "\t" + color.ColorName + "\n");

            }

            Color color2 = new Color { ColorId = 4, ColorName = "Mavi" };
            colorManager.Update(color2);

            foreach (var color in colorManager.GetAll())
            {
                Console.Write(color.ColorId + "\t" + color.ColorName + "\n");

            }

            Console.WriteLine("Silmek istediğiniz rengin idsini girin...");
            id = Convert.ToInt32(Console.ReadLine());


            List<Color> colors = new List<Color>();
            colors = colorManager.GetById(id);

            colorManager.Delete(colors[0]);

            foreach (var color in colorManager.GetAll())
            {
                Console.Write(color.ColorId + "\t" + color.ColorName + "\n");

            }

            Console.WriteLine("----------------------------------------------------\n");


            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car1 = new Car { Id = 6, ColorId = 3, BrandId = 3, ModelYear = "2021", DailyPrice = 100000, Description = "Açıklama" };

            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.Write(car.Id + "\t" +car.BrandId + "\t" +car.ColorId + "\t" + car.DailyPrice+"\t"+car.ModelYear + "\t" +car.Description + "\n");

            }


            Car car2 = new Car { Id = 3, ColorId = 2, BrandId = 2, ModelYear = "2020", DailyPrice = 130000, Description = "Açıklama Güncel" };
            carManager.Update(car2);

            foreach (var car in carManager.GetAll())
            {
                Console.Write(car.Id + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.DailyPrice + "\t" + car.ModelYear + "\t" + car.Description + "\n");

            }

            Console.WriteLine("Silmek istediğiniz aracın idsini girin...");
            id = Convert.ToInt32(Console.ReadLine());


            List<Car> cars = new List<Car>();
            cars = carManager.GetById(id);

            carManager.Delete(cars[0]);
            
             foreach (var car in carManager.GetAll())
            {
                Console.Write(car.Id + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.DailyPrice + "\t" + car.ModelYear + "\t" + car.Description + "\n");

            }

            Console.WriteLine("----------------------------------------------------\n");



        }
    }
}
