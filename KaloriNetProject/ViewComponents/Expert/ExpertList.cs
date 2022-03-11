using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.ViewComponents.Expert
{
    public class ExpertList : ViewComponent
    {

        ExpertManager Ef = new ExpertManager(new EfExpertRepository());
        public IViewComponentResult Invoke()
        {
            var values = Ef.GetList();
            return View(values);
        }
    }
}
