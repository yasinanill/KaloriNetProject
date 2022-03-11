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
    public class Register : Controller
    {
       
        UserManager wm = new UserManager(new EfUserRepository());
 
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User p)
        {

            UserValidator wv = new UserValidator();
            ValidationResult result = wv.Validate(p); // kullanabilmek icin fludationu secmek gerekiyor


            if (result.IsValid)
            {
                p.UserStatus = true;
                p.UserMail = "deneme test";
                wm.UserAdd(p);
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
    }
}
