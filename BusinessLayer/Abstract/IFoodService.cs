using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface IFoodService
    {
        void FoodAdd(Foods foods);
        void FoodDelete(Foods foods);
        void FoodUpdate(Foods foods);
        List<Foods> GetList();
        Foods GetById(int id);

    }
}
