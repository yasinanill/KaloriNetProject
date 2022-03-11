using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
 public class EfRecipesRepository : IGenericRepository<Recipes>, IRecipesDal
     {
        //public List<Foods> GetListWithPRofil()
        //{
        //    //using (var c = new Context())
        //    //{
        //    //    return c.Foodss.Include(x => x.Profil).Tolist();
                
        //    //}
        //    throw new NotImplementedException();
        //}

    }
}
