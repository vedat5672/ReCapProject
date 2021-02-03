using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            this._cars = new List<Car>() {
                new Car{ID=1,BrandID=1,ColorID=1,DailyPrice=300,Description="ikinci el clio",ModelYear="2000"},
                new Car{ID=2,BrandID=2,ColorID=5,DailyPrice=1500,Description="BMW",ModelYear="2016"},
                new Car{ID=3,BrandID=3,ColorID=4,DailyPrice=100,Description="TOFAS CAN YAKAR",ModelYear="1995"},
                new Car{ID=4,BrandID=2,ColorID=2,DailyPrice=50,Description="ŞAHİN",ModelYear="1985"},
                new Car{ID=5,BrandID=1,ColorID=3,DailyPrice=200,Description="DOBLO",ModelYear="2002"},
            };
            
        }



        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteCar = _cars.SingleOrDefault(c => c.ID == car.ID);
            _cars.Remove(DeleteCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(int CarID)
        {
            return _cars.Where(c => c.ID == CarID).ToList();
        }

        public void Update(Car car)
        {
            Car UpdateCar = _cars.SingleOrDefault(c => c.ID == car.ID);
            UpdateCar.ColorID = car.ColorID;
            UpdateCar.BrandID = car.BrandID;
            UpdateCar.DailyPrice = car.DailyPrice;
            UpdateCar.Description = car.Description;
            UpdateCar.ModelYear = car.ModelYear;
        }
    }
}
