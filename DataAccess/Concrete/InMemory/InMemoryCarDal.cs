using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=5,ColorId=11,DailyPrice=250,ModelYear=2005,Description="Araba1"},
                new Car{Id=2,BrandId=4,ColorId=12,DailyPrice=350,ModelYear=2010,Description="Araba2"},
                new Car{Id=3,BrandId=3,ColorId=13,DailyPrice=450,ModelYear=2008,Description="Araba3"},
                new Car{Id=4,BrandId=2,ColorId=14,DailyPrice=150,ModelYear=2015,Description="Araba4"},
                new Car{Id=5,BrandId=1,ColorId=15,DailyPrice=550,ModelYear=2021,Description="Araba5"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

    }
}
