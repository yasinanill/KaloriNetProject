using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class IGenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Create(T t)
        {
            Context c = new Context();
            c.Add(t);
            c.SaveChanges();
        } public void Delete(T t)
        {
            Context c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
        public T GetById(int id)
        {
            Context c = new Context();
            return c.Set<T>().Find(id);
        }
        public T GetByUserId(string id)
        {
            throw new NotImplementedException();
        }
        public List<T> GetListAll()
        {
            Context c = new Context();
            return c.Set<T>().ToList();         
        
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
             return c.Set<T>().Where(filter).ToList();
        }

        public virtual void Update(T t)
        {
            Context c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
