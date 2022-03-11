using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.ViewComponents.Food
{
    public class FoodMainList : ViewComponent
    {
        FoodManager Ef = new FoodManager(new EfFoodRepository());
        public IViewComponentResult Invoke(int id)
        {
            id = 1;
            var values = Ef.GetFoodByID(id);
            return View(values);
        }

    }
}
