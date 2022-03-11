
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{
    [AllowAnonymous]
    public class ExpertController : Controller
    {

        ExpertManager Ef = new ExpertManager(new EfExpertRepository());
        
        [Authorize]
        public IActionResult Index()
        {
         
            return View();
        }
        public PartialViewResult AnaSayfaExpert()
        {

            var values = Ef.GetListAll();
            return PartialView(values);

        }
        public PartialViewResult NawbarEx()
        {

            return PartialView();

        } 
        public IActionResult NewFoodByExpert()
        {

            return View();

        }  


        [HttpGet]
        public IActionResult EditProfil(int id)
        {
            var value = Ef.GetById(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult EditPRofil(Expert p)
        {
            
            Ef.ExpertUpdate(p);
            return View();

        } 

    }
}
