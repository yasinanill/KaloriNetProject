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
    public class RecipesManager : IRecipesService

    {

        IRecipesDal _recipesDal;

        public RecipesManager(IRecipesDal recipesDal)
        {
            _recipesDal = recipesDal;
        }

        public RecipesManager()
        {
            _recipesDal = new EfRecipesRepository();
        }
        public List<Recipes> GetRecipesByID(int id)
        {
            return _recipesDal.GetListAll(x => x.RecipesID == id);

        }

        public Recipes GetById(int id)
        {
            return _recipesDal.GetById(id);
        }

        public List<Recipes> GetList()
        {
            return _recipesDal.GetListAll();
        }

        public void RecipesAdd(Recipes recipes)
        {
            throw new NotImplementedException();
        }

        public void RecipesDelete(Recipes recipes)
        {
            throw new NotImplementedException();
        }

        public void RecipesUpdate(Recipes recipes)
        {
            throw new NotImplementedException();
        }
    }
}