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
        public IActionResult HighCarbo(string p)
        {
     
            var values = rm.GetFoodByCal();
            return View(values);

        }

        public IActionResult GetFoodByCal1(string p)
        {

            var values = rm.GetRecipesByCal();
            return View(values);

        }
        public IActionResult GetFoodByCal2(string p)
        {

            var values = rm.GetRecipesByCal2();
            return View(values);

        }
        public IActionResult GetFoodByCal3(string p)
        {

            var values = rm.GetFoodByCal3();
            return View(values);

        }
    }
}
