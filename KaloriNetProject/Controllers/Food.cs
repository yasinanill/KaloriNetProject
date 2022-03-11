using BusinessLayer.Concrete;
using BusinessLayer.ValidationResult;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{
    [AllowAnonymous]
    public class Food : Controller
    {

        FoodManager fm = new FoodManager(new EfFoodRepository());
        EfFoodRepository efFoodRepository = new EfFoodRepository();
        public IActionResult Index(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(efFoodRepository.GetListAll(x => x.FoodName== p));
            }
            var values = fm.GetList();
            return View(values);
        }
        public PartialViewResult HomeList()
        {
            var values = fm.GetList();
            return PartialView(values);


        }

        public IActionResult FoodDetail(int id)
        {
            var values = fm.GetFoodByID(id);
            return View(values);

        } 
        public IActionResult FoodCalorieBurn(int id)
        {
            var values = fm.GetFoodByID(id);
            return View(values);

        }
        public IActionResult CalString(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(efFoodRepository.GetListAll(x => x.FoodName == p || x.FoodCalorie.ToString() == p));
            }
            var values = fm.GetFoodByCal();
            return View(values);

        } 
        public IActionResult HighCarbo(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(efFoodRepository.GetListAll(x => x.FoodName == p || x.FoodCalorie.ToString() == p));
            }
            var values = fm.GetFoodByCarbo();
            return View(values);

        }
        public IActionResult HighProtein(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(efFoodRepository.GetListAll(x => x.FoodName == p));
            }
            var values = fm.GetFoodByPro();
            return View(values);

        } 
        public IActionResult HighFat(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(efFoodRepository.GetListAll(x => x.FoodName == p));
            }
            var values = fm.GetFoodByFat();
            return View(values);

        }


        [HttpGet]
        public IActionResult NewFood()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewFood(Foods s)
        {

            FoodValidator fm = new FoodValidator();
            ValidationResult result = fm.Validate(s); // kullanabilmek icin fludationu secmek gerekiyor


            if (result.IsValid)
            {
                s.FoodStatus = true;
                efFoodRepository.Add(s);
                return RedirectToAction("Index", "Food");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public IActionResult CalorieSum(string p)
        {
            if (!string.IsNullOrEmpty(p))
            {
                return View(efFoodRepository.GetListAll(x => x.FoodName == p));
            }
            var values = fm.GetList();
            return View(values);

        }
    }
}
