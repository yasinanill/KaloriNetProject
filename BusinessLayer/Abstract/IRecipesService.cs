using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IRecipesService
    {
        void RecipesAdd(Recipes  recipes);
        void RecipesDelete(Recipes recipes);
        void RecipesUpdate(Recipes recipes);
        List<Recipes> GetList();
        Recipes GetById(int id);
    }
}
