﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() 
            {
                new Car{Id = 1, BrandId = 1, ColorId=1, ModelYear=2020, Description="Dizel Otomatik", DailyPrice=300},
                new Car{Id = 2, BrandId = 1, ColorId=2, ModelYear=2020, Description="Dizel Manuel", DailyPrice=250},
                new Car{Id = 3, BrandId = 2, ColorId=1, ModelYear=2021, Description="Benzinli Otomatik", DailyPrice=400},
                new Car{Id = 4, BrandId = 3, ColorId=3, ModelYear=2018, Description="Dizel Manuel", DailyPrice=200},
                new Car{Id = 5, BrandId = 3, ColorId=4, ModelYear=2015, Description="Benzinli Manuel", DailyPrice=150}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c=> c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;

        }
    }
}