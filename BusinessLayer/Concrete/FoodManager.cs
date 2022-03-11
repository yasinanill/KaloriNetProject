using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FoodManager : IFoodService

    {

        IFoodDal _foodDal;

        public FoodManager()
        {
            _foodDal = new EfFoodRepository();
        }

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void FoodAdd(Foods foods)
        {
            _foodDal.Add(foods);
        }

        public void FoodDelete(Foods foods)
        {
            _foodDal.Delete(foods);
        }

        public void FoodUpdate(Foods foods)
        {
            _foodDal.Update(foods);
        }
        public List<Foods> GetFoodByID(int id)
        {
            return _foodDal.GetListAll(x => x.FoodID == id);

        }
        public List<Foods> GetFoodByCal()
        {
            return _foodDal.GetListAll(x => x.FoodCalorie <= 100);

        } 
        public List<Foods> GetFoodByPro()
        {
            return _foodDal.GetListAll(x => x.FoodProtein >= 60);

        } 
        public List<Foods> GetFoodByFat()
        {
            return _foodDal.GetListAll(x => x.FoodFat >= 60);

        }
        public List<Foods> GetFoodByCarbo()
        {
            return _foodDal.GetListAll(x => x.Foodcarbo >= 80);

        }
        public Foods GetById(int id)
        {
            return _foodDal.GetById(id);
        }

        public List<Foods> GetList()
        {
            return _foodDal.GetListAll();
        }
        public List<Foods> GetListAll()
        {
            return _foodDal.GetListAll();
        }
    }
}
