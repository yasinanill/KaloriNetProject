using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FoodRepository : IFoodDal
    {
        Context c = new Context();

        public void Add(Foods t)
        {
            throw new NotImplementedException();
        }

        public void AddFoods(Foods foods)
        {
            c.Add(foods);
            c.SaveChanges();
        }

        public void Delete(Foods t)
        {
            throw new NotImplementedException();
        }

        public void DeleteFoods(Foods foods)
        {
            c.Remove(foods);
            c.SaveChanges();
        }

        public Foods GetbyId(int id)
        {

            return c.Foodss.Find(id); 
        }

        public Foods GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Foods> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Foods> GetListAll(Expression<Func<Foods, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Foods> GetListWithPRofil()
        {
            throw new NotImplementedException();
        }

        public List<Foods> List(Expression<Func<Foods, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Foods> ListAllFoods()
        {
            return c.Foodss.ToList();
        }

        public void Update(Foods t)
        {
            throw new NotImplementedException();
        }

        public void UpdateFoods(Foods foods)
        {
            c.Update(foods);
            c.SaveChanges();
        }
    }
}
