using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{
    [AllowAnonymous]
    public class Profils : Controller
    {


        FoodManager fm = new FoodManager(new EfFoodRepository());
        ProfilManager pm = new ProfilManager(new EfProfilRepository());
        EfFoodRepository efFoodRepository = new EfFoodRepository();
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);

        }
        [HttpGet]
        public IActionResult besinEkle()
        {



            List<SelectListItem> FoodValues = (from x in fm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.FoodName + " " + x.FoodCalorie ,
                                                   Value = x.FoodID.ToString()


                                               }
                                               ).ToList();

            ViewBag.cv = FoodValues;
            return View();
        }
        [HttpPost]
        public IActionResult besinEkle(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(efFoodRepository.GetListAll(x => x.FoodName == p));
            }
            var values = fm.GetList();
            return PartialView(values);

        }

    }
}