using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstarct
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car product);
        void Update(Car product);
        void Delete(Car product);
        List<Car> GetAllByCategory(int categoryId);
    }
}
