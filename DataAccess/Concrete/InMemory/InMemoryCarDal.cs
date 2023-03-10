using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car> {
                new Car{Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 350, ModelYear = 2006, Description = "Partner"},
                new Car{Id = 2, BrandId = 4, ColorId = 2, DailyPrice = 400, ModelYear = 2010, Description = "Accent"},
                new Car{Id = 3, BrandId = 3, ColorId = 1, DailyPrice = 275, ModelYear = 2007, Description = "Clio"},
                new Car{Id = 4, BrandId = 2, ColorId = 5, DailyPrice = 750, ModelYear = 2021, Description = "Jetta"},
                new Car{Id = 5, BrandId = 2, ColorId = 4, DailyPrice = 900, ModelYear = 2022, Description = "Passat"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            var carToReturn = _cars.SingleOrDefault(_car => _car.Id == id);
            return carToReturn;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(car => car.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
