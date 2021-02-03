using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Car> GetAll()
        {
            //iş kuralları
            //Yetkisi Varmı


            return _productDal.GetAll();
        }

        public List<Car> GetAllByCarID(int carID)
        {
            return _productDal.GetByID(carID);
        }
    }
}
