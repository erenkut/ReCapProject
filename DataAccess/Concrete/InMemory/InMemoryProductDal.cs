using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _products;
        public InMemoryProductDal()
        {
            _products = new List<Car> {
            new Car{ProductId=1, BrandId=1, ColorId=123456, DailyPrice=300, ModelYear=2018 ,Description="Mercedes-Benz"},
            new Car { ProductId = 2, BrandId = 2, ColorId = 654321, DailyPrice = 400, ModelYear = 2006, Description = "audi r8" },
            new Car { ProductId = 3, BrandId = 3, ColorId = 123654, DailyPrice = 500, ModelYear = 1969, Description = "Nissan GT-R" },
            new Car { ProductId = 4, BrandId = 4, ColorId = 123465, DailyPrice = 500, ModelYear = 1994, Description = "Toyota Supra" },
            new Car { ProductId = 5, BrandId = 5, ColorId = 651234, DailyPrice = 750, ModelYear = 2019, Description = "BMW" },
            };
        }
        public void Add(Car product)
        {
            _products.Add(product);
        }

        public void Delete(Car product)
        {
            Car productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Car> GetAll()
        {
            return _products;
        }

        public void Update(Car product)
        {
            Car productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ColorId = product.ColorId;            
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
            productToUpdate.ModelYear = product.ModelYear;

        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }

}
