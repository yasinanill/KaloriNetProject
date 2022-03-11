using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{
    [AllowAnonymous]
    public class RecipesController : Controller
    {
        RecipesManager rm = new RecipesManager( new EfRecipesRepository());
        public IActionResult Index()
        {
            var values = rm.GetList();
            return PartialView(values);

        }
        public IActionResult RecipesDetail(int id)
        {
            var values = rm.GetRecipesByID(id);
            return View(values);
        }
    }
}
